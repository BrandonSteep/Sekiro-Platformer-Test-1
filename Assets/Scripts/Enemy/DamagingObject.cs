using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagingObject : MonoBehaviour
{
    [SerializeField] private LayerMask damageableLayers;
    
    void OnCollisionEnter2D(Collision2D){
        if ((damageableLayers & (1 << collision.gameObject.layer)) != 0)
        {
            IStatus otherStatus = collision.gameObject.GetComponent<IStatus>();
            otherStatus.TakeDamage(1, new Vector2(this.transform.position.x, this.transform.position.y));
        }
    }
}
