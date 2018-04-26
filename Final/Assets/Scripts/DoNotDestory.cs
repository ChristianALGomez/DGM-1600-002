using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoNotDestory : MonoBehaviour {


    public static DoNotDestory instance = null;

    public void Awake() //singlton
    {
        if (instance == null)  //if instance is not assigned
        {
            instance = this.gameObject.GetComponent<DoNotDestory>();  //then assign instance to this object
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);  //then destroy this object
        }
        DontDestroyOnLoad(gameObject);
    }

    public void Update()
    {
        if (SceneManager.GetActiveScene().name == "Menu")
        {
            Destroy(gameObject);
        }
    }

}
