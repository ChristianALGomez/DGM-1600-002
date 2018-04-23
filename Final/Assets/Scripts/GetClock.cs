using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetClock : MonoBehaviour {

    public Text timerText;
    public Clock startTime;

    void Start()
    {
        timerText.text = startTime.time.ToString();
    }



}
