using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parry : MonoBehaviour
{
    [SerializeField] private GameObject energyShield;
    [SerializeField] private float cooldownTimer;
    [SerializeField] private bool canAttack = true;

    void Update(){
        if(Input.GetMouseButtonDown(1) && canAttack){
            // Debug.Log("Parry Pressed");
            SpawnShield();
        }
    }

    private void SpawnShield(){
        DisableAttack();
        Instantiate(energyShield, this.transform);
        Invoke("EnableAttack", cooldownTimer);
    }

    public void EnableAttack(){
        canAttack = true;
    }

    public void DisableAttack(){
        canAttack = false;
    }
}
