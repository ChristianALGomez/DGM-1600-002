using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour {

    public int health;


    private void Awake()
    {
        GameManger.BrickCount++;
        print(GameManger.BrickCount);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;


        //if our health gets to zero
        if (health <= 0)
        {
            //then destroy this object
            Destroy(gameObject);
            GameManger.BrickCount--;
            print(GameManger.BrickCount);

            if(GameManger.BrickCount == 0)
            {
                FindObjectOfType<GameManger>().LoadNextLevel();
            }
        }
    }

}
