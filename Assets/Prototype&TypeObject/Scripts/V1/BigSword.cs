using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSword : Weapon {
	protected override void DoAttack(Target target)
	{
		target.TakeDamage(10);

		if (UnityEngine.Random.Range(0, 100) <= 30)
		{
			target.Stun(2);
		}
	}

	
}
