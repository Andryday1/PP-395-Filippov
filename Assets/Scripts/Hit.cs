using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public Animator animator;

    public Transform AttackPoint;
    public LayerMask enemyLayers;

    public float AttackRange = 0.5f;
    public int AttackDamage = 40;

    public float AttackRate = 2f;
    float nextAttackTime = 0f;

    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetMouseButton(0))
            {
                Attack();
                nextAttackTime = Time.time + 1f / AttackRate;
            }
        }
    }

    void Attack()
    {
        // Play an attack animation
        animator.SetTrigger("Attack");
        // Detect enemies
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, AttackRange, enemyLayers);
        // Damage
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<MobsHealth>().TakeDamage(AttackDamage);
        }

    }

    void OnDrawGizmosSelected()
    {
        if (AttackPoint == null)
            return;

        Gizmos.DrawWireSphere(AttackPoint.position, AttackRange);
    }
}
