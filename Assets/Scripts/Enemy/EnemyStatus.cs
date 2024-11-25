using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour, IStatus
{
    [SerializeField] private EnemyStats stats;
    [SerializeField] private int currentHealth;

    void OnEnable(){
        currentHealth = stats.GetHealth();
    }

    public void TakeDamage(int damageAmount){
        currentHealth -= damageAmount;
        if(currentHealth <= 0){
            Die();
        }
    }

    public void Heal(int healAmount){}

    public void Die(){
        Destroy(this.gameObject);
    }
}
