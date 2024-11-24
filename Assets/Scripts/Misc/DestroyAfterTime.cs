using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [SerializeField] private float timeInSeconds;

    void OnEnable(){
        Invoke("DestroyObject", timeInSeconds);
    }

    private void DestroyObject(){
        Debug.Log($"Destroying {this.gameObject.name} Now");
        Destroy(this.gameObject);
    }
}
