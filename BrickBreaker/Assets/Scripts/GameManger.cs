using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManger : MonoBehaviour
{

    public static GameManger instance = null;


    void Awake()
    {
        //Singleton
        if (instance == null)  //if instance is not assigned
        {
            instance = this;  //then assign instance to this object
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);  //then destroy this object
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void Ending(string endscreen)
    {
        SceneManager.LoadScene(endscreen);
    }

}