using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mele : MonoBehaviour
{
    [SerializeField]
    int damage = 10;
    private void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            Debug.Log("left mouse pressed");
        }
    }
}