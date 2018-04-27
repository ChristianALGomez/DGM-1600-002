using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
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
        theGameManger.LoadLevel("GameWin");
        EndTime.Finished();
    }
}