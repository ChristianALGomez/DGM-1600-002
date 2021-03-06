﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoulPack : MonoBehaviour {

    public enum Power { Health };
    public Power powerupType;
    //public Animation[] graphics;
    //public Animator animator;
    public GameObject pickupEffect;
    public GameObject player;
    public Manager managerScript;
    //public HP HPScript;

    private void Awake()
    {
        managerScript = GameObject.Find("GameManager").GetComponent<Manager>();
        //HPScript = GameObject.Find("HP").GetComponent<HP>();
    }

    public void GetHealth()
    {
        managerScript.IncrementHP(1);
        managerScript.ChangeLD();
        //HPScript.IncrementHP(1);
        //HPScript.ChangeLD();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

        // spawn cool effect
        Instantiate(pickupEffect, transform.position, transform.rotation);
        Debug.Log("Soul pack picked up.");

        GetHealth();
        // apply effect to the player

        Destroy(gameObject);
    }


}
