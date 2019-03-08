using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTesterV2 : MonoBehaviour {

	[SerializeField]
	private WeaponV2 weapon;

	[SerializeField]
	private Target target;

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			weapon.Attack(target);
		}
	}
}
