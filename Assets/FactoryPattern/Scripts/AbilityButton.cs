using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityButton : MonoBehaviour {

	private Button button;
	internal Ability ability;


	private void Start()
	{
		button = GetComponent<Button>();
		button.GetComponentInChildren<Text>().text = ability.Name;
		button.onClick.AddListener(ActivateAbility);
	}

	private void ActivateAbility()
	{
		ability.Process();
	}
}
