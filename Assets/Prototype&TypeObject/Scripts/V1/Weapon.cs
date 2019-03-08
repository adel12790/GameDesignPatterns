using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour {

	public void Attack(Target target)
	{
		DoAttack(target);
		Debug.Log("You " + DamageMsg() + " " + target.name);
	}
	protected abstract void DoAttack(Target target);
	protected virtual string DamageMsg() { return "hit"; }
}
