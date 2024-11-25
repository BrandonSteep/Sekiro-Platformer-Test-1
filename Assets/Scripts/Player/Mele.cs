using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mele : MonoBehaviour
{
    [SerializeField]
    int damage = 10;
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;




    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MeleAttack();
        }
    }

    private void MeleAttack() 
    {
        animator.SetTrigger("AttackMele");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies) 
        {
            // Debug.Log("We hit " + enemy.name);
            IStatus enemyStatus = enemy.gameObject.GetComponent<IStatus>();
            enemyStatus.TakeDamage(1);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
