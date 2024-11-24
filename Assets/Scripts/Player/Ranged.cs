using System.Collections;
using System.Collections.Generic;
using TarodevController;
using UnityEngine;

public class Ranged : MonoBehaviour
{
    [SerializeField]
    int damage = 10;
    public Transform firePoint;
    public LayerMask enemyLayers;
    public GameObject projectilePrefab;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) 
        {
            RangedAttack();
        }
    }
    private void RangedAttack() 
    {
        // avoids errors
        if (firePoint == null) return;

        PlayerAnimator  playerAnimator = GameObject.FindWithTag("Player").GetComponent<PlayerAnimator>();

        Vector2 direction = playerAnimator.facingRight ? Vector2.right : Vector2.left;

        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        projectile.GetComponent<PlayerProjectile>().SetDirection(direction);
    }
}
