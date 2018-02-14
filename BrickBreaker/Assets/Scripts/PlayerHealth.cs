using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int startingHealth = 3;
    public int currentHealth;
    public AudioClip deathClip;

    bool isDead;
    bool fall;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("object Entered teh trigger");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("object exited the trigger");
    }

    private void Awake()
    {
        currentHealth = startingHealth;
    }

    public void falling (int amount)
    {
        fall = true;
        currentHealth -= amount;
    }
}
