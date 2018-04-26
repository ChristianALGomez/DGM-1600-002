using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{

    public Manager theGameManger;
    public Holder EndTime;

    private void Start()
    {
        theGameManger = GameObject.Find("GameManager").GetComponent<Manager>();
        EndTime = GameObject.Find("Holder").GetComponent<Holder>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        print("GameOver!!");
        //theGameManger.LoadLevel("GameOver");
        theGameManger.HP.value--;
        Destroy(collision.gameObject);

        if (theGameManger.HP.value <= 0)
        {
            theGameManger.LoadLevel("GameOver");
            EndTime.Finished();

        }
        if (theGameManger.HP.value > 0)
        {
            theGameManger.Respawn();
        }
        theGameManger.ChangeLD();
    }
}