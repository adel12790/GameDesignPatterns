using Common.FSM;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITest2 : MonoBehaviour
{
	private FSM fsm;
	private FSMState MoveLeftState;
	private FSMState MoveRightState;
	private TextAction MoveLeftTextAction;
	private TextAction MoveRightTextAction;
	private MoveAction MoveLeftAction;
	private MoveAction MoveRightAction;

	// Use this for initialization
	void Start()
	{
		fsm = new FSM("AITest FSM Two");
		MoveLeftState = fsm.AddState("MoveLeftState");
		MoveRightState = fsm.AddState("MoveRightState");
		MoveLeftAction = new MoveAction(MoveLeftState);
		MoveRightAction = new MoveAction(MoveRightState);
		MoveLeftTextAction = new TextAction(MoveLeftState);
		MoveRightTextAction = new TextAction(MoveRightState);

		//This adds the actions to the state and add state to it's transition map
		MoveLeftState.AddAction(MoveLeftTextAction);
		MoveLeftState.AddAction(MoveLeftAction);
		MoveRightState.AddAction(MoveRightTextAction);
		MoveRightState.AddAction(MoveRightAction);

		MoveLeftState.AddTransition("ToRight", MoveRightState);
		MoveRightState.AddTransition("ToLeft", MoveLeftState);

		//this initializes the actions
		MoveLeftTextAction.Init("AI Moving Left", 1f, "");
		MoveRightTextAction.Init("AI Moving Right", 1f, "");
		MoveLeftAction.Init(this.transform, new Vector3(1, 0, 0), new Vector3(-1, 0, 0), 1.0f, "ToRight");
		MoveRightAction.Init(this.transform, new Vector3(-1, 0, 0), new Vector3(1, 0, 0), 1.0f, "ToLeft");

		//Starts the FSM
		fsm.Start("MoveLeftState");
	}

	// Update is called once per frame
	void Update()
	{
		fsm.Update();
	}
}
