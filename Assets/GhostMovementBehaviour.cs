using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovementBehaviour : MonoBehaviour {
    Transform player;
    float movementSpeed = 100f;

    // Use this for initialization
    void Awake () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        //gameObject.transform      
    }
}
