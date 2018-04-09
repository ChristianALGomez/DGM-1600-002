using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Holder : MonoBehaviour {

    public Text scoreboard;
    public Text levelDisplay;
    private int score;
    

    public void IncrementScore(int value)
    {
        score += value;
        scoreboard.text = "Score: " + score.ToString();
    }
}
