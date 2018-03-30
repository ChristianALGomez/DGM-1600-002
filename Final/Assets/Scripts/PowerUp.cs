using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PowerUp : MonoBehaviour {

    public enum Power { Health, Speed};
    public Power powerupType;
    public SpriteRenderer rend;
    public Sprite[] images;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }


    private void Update()
    {
        switch (powerupType)
        {
            case Power.Health:
                //do some stuff
                rend.sprite = images[0];
                break;
            case Power.Speed:
                rend.sprite = images[1];
                //do some other stuff
                break;
        }
    }



}
