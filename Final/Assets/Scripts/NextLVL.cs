using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLVL : MonoBehaviour
{

    public Manager theGameManger;

    private void Start()
    {
        theGameManger = GameObject.Find("GameManager").GetComponent<Manager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
     
    }
}