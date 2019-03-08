using UnityEngine;

public abstract class Ability
{
	public abstract string Name { get; }

	public virtual void Process() {
		Debug.Log("Child name: " + Name);
	}

	public virtual void Process(GameObject gameObject) {
		Debug.Log("Child name: " + Name);
	}
}
