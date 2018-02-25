using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Brick: MonoBehaviour {

    public int health;
    public Sprite[] sprites;


    private void Awake()
    {
        GameManger.BrickCount++;
        print(GameManger.BrickCount);
        GetComponent<SpriteRenderer>().sprite = sprites[health];
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;
        GetComponent<SpriteRenderer>().sprite = sprites[health];


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
