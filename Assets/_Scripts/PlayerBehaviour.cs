using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float hMov = Input.GetAxis("Horizontal");
        float vMov = Input.GetAxis("Vertical");

        transform.Translate(hMov * speed * Time.deltaTime, 0, vMov * speed * Time.deltaTime);
    }
}
