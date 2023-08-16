using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeballManager : MonoBehaviour
{
    public GameObject dodgeballPrefab;
    public Transform spawnPoint;
    public float spawnInterval = 2.0f;

    private float nextSpawnTime;

    private void Start()
    {
        nextSpawnTime = Time.time + spawnInterval;
    }

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnDodgeball();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    private void SpawnDodgeball()
    {
        Instantiate(dodgeballPrefab, spawnPoint.position, Quaternion.identity);
    }
}

