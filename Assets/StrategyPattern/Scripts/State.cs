using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Actions/State")]
public class State : ScriptableObject {

	public List<Action> actions = new List<Action>();
	public void Tick(ActionHook o)
	{
		for (int i = 0; i < actions.Count; i++)
		{
			actions[i].Execute(o);
		}
	}
}
