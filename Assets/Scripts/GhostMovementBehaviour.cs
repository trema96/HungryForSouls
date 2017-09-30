using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMovementBehaviour : MonoBehaviour {
    Transform target;
    
    public AudioClip spookSound;
    public AudioClip onCollisionSound;
    AudioSource ghostSound;
    public float speed;
    public float lifetime = 60f;


    // Use this for initialization
    void Awake () {
        ghostSound = GetComponent<AudioSource>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        ghostSound.clip = spookSound;
        ghostSound.Play();
    }

    // Update is called once per frame
  
    void Update()
    {

        lifetime -= Time.deltaTime;

        if (lifetime < 30)
        {
            speed = 1;    
        }

        if (lifetime < 0)
        {
            Destroy(gameObject);  
        }

        float step = speed * Time.deltaTime;
       transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.position.x, transform.position.y, target.position.z), step);

       Vector3 targetPostition = new Vector3(target.position.x,
                                       transform.position.y,
                                       target.position.z);
        transform.LookAt(targetPostition);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player") { 
            ghostSound.clip = onCollisionSound;
            ghostSound.Play();
        }
    }
}
