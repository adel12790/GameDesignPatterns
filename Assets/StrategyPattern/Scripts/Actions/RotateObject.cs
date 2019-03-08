using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/Rotate object based on Input")]
public class RotateObject : Action
{
	public InputAxis horizontal;
	public InputAxis vertical;
	public TransformVariable cameraTransform;

	public override void Execute(ActionHook o)
	{
		if (cameraTransform.value == null)
			return;

		Transform t = o.mTransform;

		float h = horizontal.value;
		float v = vertical.value;

		Vector3 RotateDir = cameraTransform.value.forward * v;
		RotateDir += cameraTransform.value.right * h;

		if (RotateDir == Vector3.zero)
		{
			RotateDir = t.forward;
		}

		Quaternion targetRot = Quaternion.LookRotation(RotateDir);
		Quaternion rotation = Quaternion.Slerp(t.rotation, targetRot, Time.deltaTime * 8);
		t.rotation = rotation;


	}
}
