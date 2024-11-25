using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour, IStatus
{
    [SerializeField] private EnemyStats stats;
    [SerializeField] private int currentHealth;

    [SerializeField] private Rigidbody2D rb;

    void OnEnable(){
        rb = GetComponent<Rigidbody2D>();
        currentHealth = stats.GetHealth();
    }

    public void TakeDamage(int damageAmount, Vector2 hitPosition){
        Debug.Log($"Taken {damageAmount} points of damage");
        currentHealth -= damageAmount;
        rb.AddForce(new Vector2(this.transform.position.x, this.transform.position.y) - hitPosition * damageAmount, ForceMode2D.Impulse);
        if(currentHealth <= 0){
            Die();
        }
    }

    public void Heal(int healAmount){}

    public void Die(){
        Destroy(this.gameObject);
    }
}