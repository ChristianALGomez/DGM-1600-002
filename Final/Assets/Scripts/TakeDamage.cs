using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{

    public enum Power { Health };
    public GameObject player;
    public GameObject pickupEffect;
    public Manager managerScript;

    private void Awake()
    {
        managerScript = GameObject.Find("GameManager").GetComponent<Manager>();
    }

    public void LoseHealth()
    {
        managerScript.IncrementHP(-1);
        managerScript.ChangeLD();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

        // spawn cool effect
        Instantiate(pickupEffect, transform.position, transform.rotation);
        Debug.Log("Soul pack picked up.");

        LoseHealth();
        // apply effect to the player

        Destroy(gameObject);
    }
}

