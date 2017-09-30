using UnityEngine;
using System.Collections;

public class Policebehavior : MonoBehaviour
{
    Transform player;               
    //PlayerHealth playerHealth;      
    //EnemyHealth enemyHealth;        
    //NavMeshAgent nav;             


    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //playerHealth = player.GetComponent<PlayerHealth>();
       // enemyHealth = GetComponent<EnemyHealth>();
       // nav = GetComponent<Nav>();
    }


    void Update()
    {
      /*  if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
        //    nav.SetDestination(player.position);
        }
        else
        {
          //  nav.enabled = false;
        }
        */
    }
}