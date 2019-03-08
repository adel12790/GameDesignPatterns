using UnityEngine;
using UnityEngine.UI;

public class StartFireAbility : Ability
{
	public override string Name
	{
		get
		{
			return "fire";
		}
	}

	public override void Process(GameObject gameObject)
	{
		base.Process(gameObject);
		var text = gameObject.GetComponent<Text>();
		text.text = Name;
	}
}
