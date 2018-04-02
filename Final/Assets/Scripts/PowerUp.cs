using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PowerUp : MonoBehaviour {

    public enum Power { Health, Speed};
    public Power powerupType;
    public SpriteRenderer rend;
    public Sprite[] images;
    public Animation[] graphics;
    public Animator animator;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        switch (powerupType)
        {
            case Power.Health:
                //play.anim = anims[0];
                //animator. = images[0];
                break;
            case Power.Speed:
                break;
            default:
                break;
        }


        /*switch (powerupType)
        {
            case Power.Health:
                //do some stuff
                //rend.sprite = images[0];
                break;
            case Power.Speed:
                rend.sprite = images[1];
                //do some other stuff
                break;
        }*/
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("PowerUP");
        switch (powerupType)
        {
            case Power.Health:
                collider.GetComponent<Health>().IncrementHealth(1);

                break;
            case Power.Speed:
                break;
        }
        Destroy(gameObject);
    }

}
