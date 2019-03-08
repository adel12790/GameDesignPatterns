using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTester : MonoBehaviour {

	[SerializeField]
	private Weapon weapon;

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
