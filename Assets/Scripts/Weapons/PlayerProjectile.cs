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
    [SerializeField] private LayerMask damageable;

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
        if (( damageable & (1 << collision.gameObject.layer)) != 0)
        {
            IStatus otherStatus = collision.gameObject.GetComponent<IStatus>();
            otherStatus.TakeDamage(1, new Vector2(this.transform.position.x, this.transform.position.y));
        }
        Destroy(gameObject);
    }
}
