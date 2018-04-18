using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{

    public static Manager instance = null;
    public GameObject[] LD;
    public int HP;
    public object currentScene;
    public GameObject player;

    // public Health HP;



    private void Update() //HP
    {
        //HP = GetComponent<Health>();
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            HP = 2;
        }

    }
    void Awake() //singleton
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

        //DontDestroyOnLoad(this.gameObject);
    }

    private void OnLevelWasLoaded(int level)
    {
        ChangeLD();
    }

    public void Respawn()
    {
        //yield return new WaitForSeconds(5);
        GameObject newplayer = Instantiate(player);
        Camera.main.GetComponent<CameraMovment>().player = newplayer;
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

    public void IncrementHP(int amount)
    {
        HP += amount;
        if (HP <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
        
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
