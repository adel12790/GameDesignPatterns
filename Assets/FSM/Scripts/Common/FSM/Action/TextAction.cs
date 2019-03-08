using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common.FSM;

public class TextAction : FSMAction
{
	private string textToShow;
	private float duration;
	private float cachedDuration;
	private string finishEvent;

	public TextAction(FSMState owner) : base(owner)
	{
	}

	public void Init(string textToShow, float duration, string finishEvent)
	{
		this.textToShow = textToShow;
		this.duration = duration;
		this.cachedDuration = duration;
		this.finishEvent = finishEvent;
	}

	public override void OnEnter()
	{
		base.OnEnter();
		if (duration <= 0)
		{
			Finish();
			return;
		}
	}

	public override void OnExit()
	{
		base.OnExit();
	}

	public override void OnUpdate()
	{
		base.OnUpdate();
		duration -= Time.deltaTime;

		if (duration <= 0)
		{
			Finish();
			return;
		}

		Debug.Log(textToShow);
	}

	public void Finish()
	{
		if (!string.IsNullOrEmpty(finishEvent))
		{
			GetOwner().SendEvent(finishEvent);
		}
		duration = cachedDuration;
	}
}
