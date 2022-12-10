using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Player", order = 1)]
public class PlayerStats : ScriptableObject
{
    public float health;
    public float damage;
    public float attackSpeed;
    public float speed;
}
