using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionHook : MonoBehaviour
{

	public State currentState;
	internal Transform mTransform;
	private void Start()
	{
		mTransform = this.transform;
	}
	private void Update()
	{
		if (currentState != null)
		{
			currentState.Tick(this);

		}
	}
}
