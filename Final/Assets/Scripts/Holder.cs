using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Holder : MonoBehaviour {

    private Holder instance;
    public Text scoreboard;
    public Text levelDisplay;
    private int score;

    /*public void Awake() //singlton
    {
        if (instance == null)  //if instance is not assigned
        {
            instance = this.gameObject.GetComponent<Holder>();  //then assign instance to this object
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);  //then destroy this object
        }

        DontDestroyOnLoad(gameObject);
    }*/

    public void IncrementScore(int value)
    {
        score += value;
        scoreboard.text = "Score: " + score.ToString();
    }
}
