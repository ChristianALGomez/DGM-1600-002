using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public GameManger theGameManger;
    public int CurrentHealth;


    private void Start()
    {
        theGameManger = FindObjectOfType<GameManger>();
    }

    private void DeadBall()
    {
        CurrentHealth--;
        print("dose tlhis work");
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        DeadBall();

        if (CurrentHealth == 0)
            theGameManger.LoadLevel("GameOver");
    }


}
