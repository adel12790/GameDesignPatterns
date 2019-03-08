using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common.FSM;

public class AITest : MonoBehaviour {

	private FSM fsm;
	private FSMState patrolState;
	private FSMState idleState;
	private TextAction patrolAction;
	private TextAction idleAction;

	private void Start()
	{
		fsm = new FSM("AITest FSM");
		idleState = fsm.AddState("IdleState");
		patrolState = fsm.AddState("PatrolState");
		idleAction = new TextAction(idleState);
		patrolAction = new TextAction(patrolState);

		//This adds the actions to the state and add state to it's transition map
		patrolState.AddAction(patrolAction);
		idleState.AddAction(idleAction);

		patrolState.AddTransition("ToIdle", idleState);
		idleState.AddTransition("ToPatrol", patrolState);

		patrolAction.Init("AI on Patrol", 3.0f, "ToIdle");
		idleAction.Init("AI on Idle", 2.0f, "ToPatrol");

		fsm.Start("IdleState");
	}

	private void Update()
	{
		fsm.Update();
	}
}
