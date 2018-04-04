using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulPack : MonoBehaviour {

    public enum Power { Health};
    public Power powerupType;
    public Animation[] graphics;
    public Animator animator;
    public GameObject pickupEffect;
    void Pickup(Collision player)
    {
        // spawn cool effect
        Instantiate(pickupEffect, transform.position, transform.rotation);
        Debug.Log("Soul pack picked up.");

        // apply effect to the player
        

        Destroy(gameObject);
    }


}
