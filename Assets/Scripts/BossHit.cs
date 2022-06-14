using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHit : MonoBehaviour
{


    public Transform AttackPoint;
    public LayerMask enemyLayers;

    public float AttackRange = 0.5f;
    public int AttackDamage = 40;

    public float AttackRate = 2f;
    float nextAttackTime = 0f;

    void Start()
    {
        
    }

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
        

    }



}
