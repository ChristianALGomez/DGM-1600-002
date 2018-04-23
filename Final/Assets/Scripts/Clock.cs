using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Clock : ScriptableObject {

    public float time;


    public void RestartClock()
    {
        time = 0;
    }


}
