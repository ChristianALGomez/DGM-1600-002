using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour {

    public Text scoreboard;
    public Score score;

    void Start ()
    {
        scoreboard.text = score.value.ToString();
	}
}
