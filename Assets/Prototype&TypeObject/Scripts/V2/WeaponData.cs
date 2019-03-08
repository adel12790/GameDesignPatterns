using UnityEngine;

[CreateAssetMenu(menuName = "Weapon Data")]
public class WeaponData : ScriptableObject
{

	public int Damage;
	public string Msg;
	public GameObject Model;
	public int StunDuration;
	public int FreezeDuration;
}
