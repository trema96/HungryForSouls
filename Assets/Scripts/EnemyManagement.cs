﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManagement : MonoBehaviour {

   // public PlayerHealth playerHealth;       
    public GameObject enemy;                
    public float spawnTime = 3f;            
    public float spawnIncreaseRate = 3f;
    public Transform[] spawnPoints;         


    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        GameObject p = GameObject.FindGameObjectWithTag("Player");
       // p.GetComponent<PlayerHealth>
        //if (playerHealth.currentHealth <= 0f)
        {
            // ... exit the function.
          //  return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
