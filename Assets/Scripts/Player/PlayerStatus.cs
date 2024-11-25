using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour, IStatus
{
    [SerializeField] private ScriptableVariable_int maxHealth;
    [SerializeField] private ScriptableVariable_int currentHealth;

    void OnEnable(){
        currentHealth.SetValue(maxHealth.GetValue());
    }

    public void TakeDamage(int damageAmount, Vector2 hitPosition){

    }

    public void Heal(int healAmount){

    }

    public void Die(){
        Destroy(this.gameObject);
    }
}
