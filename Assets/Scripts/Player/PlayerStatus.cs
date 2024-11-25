using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour, IStatus
{
    [SerializeField] private ScriptableVariable_int maxHealth;
    [SerializeField] private ScriptableVariable_int currentHealth;

    [SerializeField] private bool canTakeDamage = true;
    [SerializeField] private float iFramesInSeconds;

    void OnEnable(){
        currentHealth.SetValue(maxHealth.GetValue());
    }

    public void TakeDamage(int damageAmount, Vector2 hitPosition){
        if(canTakeDamage){
            Debug.Log($"Player Takes {damageAmount} points of Damage");
            currentHealth.AddToValue(-damageAmount);

            if(currentHealth.GetValue() <= 0){
                Die();
            }
            else{
                AddIFrames();
            }
        }
    }

    public void Heal(int healAmount){

    }

    public void Die(){
        DestroyComponents();
        Destroy(this.gameObject);
    }

    private void AddIFrames(){
        canTakeDamage = false;
        Invoke("RemoveIFrames", iFramesInSeconds);
    }

    private void RemoveIFrames(){
        canTakeDamage = true;
    }


    #region Component Destruction
    public Component[] componentsToDestroyOnDeath;

    void DestroyComponents()
    {
        // Ensure there are components to destroy
        if (componentsToDestroyOnDeath != null)
        {
            for (int i = 0; i < componentsToDestroyOnDeath.Length; i++)
            {
                if (componentsToDestroyOnDeath[i] != null)
                {
                    Destroy(componentsToDestroyOnDeath[i]);
                }
            }
        }
    }
    #endregion
}
