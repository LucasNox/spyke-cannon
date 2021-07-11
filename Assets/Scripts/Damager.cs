using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField]
    private int damage;
	public int Damage { get => damage; set => damage = value; }
}
