using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Final_Time_Score : MonoBehaviour
{

    public Holder HolderScript;
    public Text FinalTime;
    public Text FinalScore;

    public void Awake()
    {
        HolderScript = GameObject.Find("HolderScript").GetComponent<Holder>();

    }

    public void Update()
    {
        HolderScript.timerText = FinalScore;
    }


}