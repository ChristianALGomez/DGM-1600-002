﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour {

    public GameManger theGameManger;

    private void Start()
    {
        theGameManger = GameObject.Find("GameManager").GetComponent<GameManger>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("GameOver!!");
        //theGameManger.LoadLevel("GameOver");
        theGameManger.HP--;
        Destroy(collision.gameObject);

        if (theGameManger.HP <= 0)
        {
            theGameManger.LoadLevel("GameOver");
        }
        if (theGameManger.HP > 0)
        {
            theGameManger.Respawn();
        }
        theGameManger.ChangeLD();
    }
}
