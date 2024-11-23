using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset = new Vector3(0,0,-10);
    [SerializeField] private float translationFactor = 20;

    void LateUpdate(){
        if(transform.position != player.position + offset) {
        transform.position += ((player.position + offset) - transform.position) / translationFactor;           
    }
}
}
