using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parry : MonoBehaviour
{
    [SerializeField] private GameObject energyShield;

    void Update(){
        if(Input.GetMouseButtonDown(1)){
            // Debug.Log("Parry Pressed");
            SpawnShield();
        }
    }

    private void SpawnShield(){
        Instantiate(energyShield, this.transform);
    }
}
