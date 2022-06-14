using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth;

    [SerializeField] private AudioSource damageSound;

    public void TakeHit(int damage)
    {
        health -= damage;

        damageSound.Play();

        if (health <= 0)
            Destroy(gameObject);
    }

    public void SetHealth(int bonusHealth)
    {
        health += bonusHealth;

        if (health > maxHealth)
            health = maxHealth;
    }

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
