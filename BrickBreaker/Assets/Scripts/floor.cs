using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour {

    public GameManger theGameManger;
    public int HP;

    private void Start()
    {
        theGameManger = FindObjectOfType<GameManger>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("GameOver!!");
        //theGameManger.LoadLevel("GameOver");
        HP--;

        if (HP <= 0)
        {
            theGameManger.LoadLevel("GameOver");
        }
    }
}
