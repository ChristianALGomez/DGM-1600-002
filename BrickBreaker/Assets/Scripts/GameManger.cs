using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManger : MonoBehaviour
{

    public static GameManger instance = null;
    public static int BrickCount;
    public static int BLC;
    public GameObject[] LD;
    private object currentScene;
    


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
        //ChangeLD();
    }
    // activate ChangeLD when lvl is finished loading
    private void OnLevelWasLoaded(int level)
    {
        ChangeLD();
    }

    public void ChangeLD()
    {
        //
        //if current lvl is menu over/win turn it off
        if (SceneManager.GetActiveScene().name == "Menu" || SceneManager.GetActiveScene().name == "GameOver" || SceneManager.GetActiveScene().name == "GameWin")
        {
            for (int i = 0; i < LD.Length; i++)
            {
                LD[i].SetActive(false);

            }
        }
        //if current lvl is menu over/win turn it off
        else 
        {
            for (int i = 0; i < LD.Length; i++)
            {
                LD[i].SetActive(true);

            }
        }

            //if display on lvl show it
            //check life count
        }

    public void LoadLevel(string level)
    {
        BrickCount = 0;
        SceneManager.LoadScene(level);
        //if scene is loaded
        ChangeLD();
    }

    public void LoadNextLevel()
    {
        BrickCount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  //load next scene going up by 1
        ChangeLD();
    }
}