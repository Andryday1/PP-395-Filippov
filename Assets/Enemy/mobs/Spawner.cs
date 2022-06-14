using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject enemy;


    void Start()
    {
        StartCoroutine(SpawnCD());
    }

    
    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }

    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(2);
        Instantiate(enemy, SpawnPos.position, Quaternion.identity);
        Repeat();
    }
}
