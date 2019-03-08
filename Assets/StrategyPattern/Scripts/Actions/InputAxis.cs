using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Actions/Input/Axis")]
public class InputAxis : Action
{
	public string targetInput;
	public float value;


	public override void Execute(ActionHook o)
	{
		value = Input.GetAxis(targetInput);
	}
}
