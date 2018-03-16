using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int health;
    public ParticleSystem deathParticle;

    private void Start()
    {
        
    }


    private void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collided");
        health--;
        if(health <= 0)
        {
            Instantiate(deathParticle,gameObject.transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
    }

}
