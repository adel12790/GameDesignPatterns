using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Move Object Based on Input")]
public class MoveObject : Action
{

	public InputAxis horizontal;
	public InputAxis vertical;

	public override void Execute(ActionHook o)
	{

		Transform t = o.mTransform;

		float h = horizontal.value;
		float v = vertical.value;
		float moveAmount = Mathf.Clamp01(Mathf.Abs(h) + Mathf.Abs(v));

		Vector3 moveDir = t.forward * moveAmount;
		t.position += moveDir * 0.4f;

	}


}
