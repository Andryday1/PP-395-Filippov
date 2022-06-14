using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobs : MonoBehaviour
{

    public float speed;

    Transform player;
    public float stoppintDistance;

    bool angry = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) < stoppintDistance) ;
        {
            angry = true;
        }

        if(angry == true)
        {
            Angry();
        }
    }

    void Angry()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed*Time.deltaTime);
    }
}
