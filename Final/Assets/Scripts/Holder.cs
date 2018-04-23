using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Holder : MonoBehaviour {

    private Holder instance;
    public Text scoreboard;
    //public Text levelDisplay;
    //private int score;
    public Score score;
    public Text timerText;
    private float startTime;
    //public Clock startTime;

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
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f1");

        timerText.text = minutes + ":" + seconds;
    }

    public void IncrementScore(int value)
    {
        score.value += value;
        scoreboard.text = "Score: " + score.value.ToString();
    }
}
