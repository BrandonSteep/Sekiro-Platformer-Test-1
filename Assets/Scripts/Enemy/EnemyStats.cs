using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Stats/Enemy Stats")]
public class EnemyStats : ScriptableObject
{
    [SerializeField] private int health = 3;
    [SerializeField] private int damage = 1;
    [SerializeField] private float speed = 3f;
    [SerializeField] private float attackRate = 2f;

    public int GetHealth(){
        return health;
    }

    public int GetDamage(){
        return damage;
    }

    public float GetSpeed(){
        return speed;
    }

    public float GetAttackRate(){
        return attackRate;
    }
}
