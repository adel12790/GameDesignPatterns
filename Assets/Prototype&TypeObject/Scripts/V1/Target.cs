using System;
using UnityEngine;

public class Target : MonoBehaviour
{

	[SerializeField]
	private int currentHealth = 10;

	//[SerializeField]
	//private string floatingText;

	public void TakeDamage(int amount)
	{
		currentHealth -= amount;

	}

	internal void Stun(int time)
	{
		Debug.Log(this.name + " stunned for " + time + " seconds");
	}

	internal void Freeze(int time)
	{
		Debug.Log(this.name + " freezed for " + time + " seconds");
	}
}
