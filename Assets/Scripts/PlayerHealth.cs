using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class PlayerHealth : MonoBehaviour {
    public int startingHealth = 100;
    public AudioClip deathSound;
    AudioSource playerAudio;
    public Slider HealthSlider;
    float currentHealth;
    void Start()
    {
        currentHealth = startingHealth;
    }

    void Death()
    {
        playerAudio.clip = deathSound;
        playerAudio.Play();
    }

    void FixedUpdate(){
        if(currentHealth < 1)
        {
            Death();
            Debug.Log("You are dead!");
            Destroy(gameObject);
        }    
    }
}
