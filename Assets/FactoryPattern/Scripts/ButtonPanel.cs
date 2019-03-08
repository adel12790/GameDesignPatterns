using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPanel : MonoBehaviour {

	public Button buttonPrefab;
	
	private void Start()
	{
		var abilityNames = AbilityFactory.GetAbilityNames();
		foreach (var abilityName in abilityNames)
		{
			var abilityButton = Instantiate(buttonPrefab, transform);
			abilityButton.GetComponent<AbilityButton>().ability = AbilityFactory.GetAbility(abilityName);
		}
	}

}
