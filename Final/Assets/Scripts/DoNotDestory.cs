using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoNotDestory : MonoBehaviour {

    GameObject 

    //public static DoNotDestory instance = null;

    public void Awake() //singlton
    {
        /*if (instance == null)  //if instance is not assigned
        {
            instance = this.gameObject.GetComponent<DoNotDestory>();  //then assign instance to this object
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);  //then destroy this object
        }*/
        if (SceneManager.GetActiveScene().name == "GameOver")
        {
            Destroy(GameObject);
        }
        DontDestroyOnLoad(gameObject);


    }
}
