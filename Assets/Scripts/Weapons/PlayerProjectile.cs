using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    private Vector2 direction = Vector2.right;
    [SerializeField]
    private float lifetime = 5f;

    public void SetDirection(Vector2 newDirection)
    {
        Destroy(gameObject, lifetime);
        direction = newDirection.normalized;
    }
    private void Start()
    {
        rb.velocity = direction * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Enemy"){
            IStatus enemyStatus = collision.gameObject.GetComponent<IStatus>();
            enemyStatus.TakeDamage(1);
        }
        Destroy(gameObject);
    }
}
