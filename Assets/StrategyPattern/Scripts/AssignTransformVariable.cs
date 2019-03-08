using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Assign Transfrom Variable")]
public class AssignTransformVariable : Action
{
	public TransformVariable targetTransform;

	public override void Execute(ActionHook o)
	{
		targetTransform.value = o.mTransform;
		o.currentState = null; // instead of nullifing, jump to another state
	}
}
