using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPoliceMovement : MonoBehaviour {

    Transform player;
    //PlayerHealth playerHealth;  
    //EnemyFire enemyFire
    //EnemyHealth enemyHealth;        
    NavMeshAgent nav;
    float timer;


    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //playerHealth = player.GetComponent<PlayerHealth>();
        // enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
    }


    void Shoot()
    {
        Debug.Log("Shoot");
    }

    void Update()
    {
        if (Vector3.Distance(player.position, gameObject.transform.position) < 10)
        {
            nav.isStopped = true;
            RaycastHit hit;
            var rayDirection = player.position - transform.position;
            if (Physics.Raycast(transform.position, rayDirection, out hit))
            {
                if (hit.transform == player)
                {
                    Shoot();
                    transform.LookAt(player);
                }
                else
                {
                    
                }
            }
            Shoot();
        }
       
        if (Vector3.Distance(player.position, gameObject.transform.position) > 10)
        {
            nav.isStopped = false;
        }

        nav.SetDestination(player.position);
        
    }
}
