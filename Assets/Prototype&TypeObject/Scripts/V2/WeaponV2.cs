using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponV2 : MonoBehaviour {

	[SerializeField]
	private WeaponData weaponData;

	[SerializeField]
	private Transform weaponModelTransformParent; // place that the weapon actually will be positioned

	private GameObject model;

	private void OnEnable()
	{
		// on enable we if we switch it will destroy the current weapon and put the new one
		if (model != null)
		{
			Destroy(model);
		}

		if (weaponData.Model != null)
		{
			model = Instantiate(weaponData.Model); // better it would be instantiated, kept around and just enable and disable them
			try
			{
				model.transform.SetParent(weaponModelTransformParent);

			}
			catch (System.Exception)
			{

				Debug.Log("parent not set correctly");
			}
		}
	}

	public void Attack(Target target)
	{

		// we can split those effects into separate classes, maybe ScriptableObject with a reference to the target
		if (weaponData.Damage > 0)
		{
			target.TakeDamage(weaponData.Damage);
		}

		if (weaponData.StunDuration > 0)
		{
			target.Stun(weaponData.StunDuration);
		}

		if (weaponData.FreezeDuration > 0)
		{
			target.Freeze(weaponData.FreezeDuration);
		}

		string message = string.IsNullOrEmpty(weaponData.Msg) ? "hit" : weaponData.Msg;
		Debug.Log("you " + message + " " + target.name);
	}
}
