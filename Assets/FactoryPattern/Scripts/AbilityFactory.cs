using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public static class AbilityFactory  {

	private static Dictionary<string, Type> abilitiesByName;
	private static bool IsInitialized { get { return abilitiesByName != null; } }

	private static void InitializeFactory()
	{
		if (IsInitialized)	
		{
			return;
		}

		// get all the Ability subclass types in the project
		var abilityTypes = Assembly.GetAssembly(typeof(Ability)).GetTypes()
			.Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Ability)));

		abilitiesByName = new Dictionary<string, Type>();

		//Get the names and put them into the dictionary
		foreach (var type in abilityTypes)
		{
			var tempEffect = Activator.CreateInstance(type) as Ability; // Activate the class for a little bit to get the name property
			abilitiesByName.Add(tempEffect.Name, type);
		}
	}

	/// <summary>
	/// Retrun Certain Ability
	/// </summary>
	/// <param name="abilityType"></param>
	/// <returns></returns>
	public static Ability GetAbility(string abilityType)
	{
		InitializeFactory();

		if (abilitiesByName.ContainsKey(abilityType))
		{
			Type type = abilitiesByName[abilityType];
			var ability = Activator.CreateInstance(type) as Ability;
			return ability;
		}
		return null;
	}

	internal static IEnumerable<string> GetAbilityNames()
	{
		Debug.Log("test");
		InitializeFactory();
		return abilitiesByName.Keys;
	}
}
