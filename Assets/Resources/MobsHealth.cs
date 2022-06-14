using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobsHealth : MonoBehaviour
{
    public Animator animator;

    public int maxHealth = 100;
    int currentHealth;

    void Start()
    {
        

        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
            Die();
    }

    void Die()
    {
        Debug.Log("Enemy died");

        // Animator death mobs
        animator.SetBool("Dh", true);

        // Disable mobs
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;

    }

  

}
