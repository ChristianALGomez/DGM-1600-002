using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManger : MonoBehaviour {

    public GameObject[] LD;
    public int HP;
    private object currentScene;
    public GameObject player;



    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            HP = 3;
        }

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
        //if current lvl is not menu over/win turn it on
        else
        {
            for (int i = 0; i < LD.Length; i++)
            {
                LD[i].SetActive(false);
                if (HP - 1 >= i)
                {
                    LD[i].SetActive(true);
                }
            }
        }
    }
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
        ChangeLD();
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  //load next scene going up by 1
        ChangeLD();
    }
}
