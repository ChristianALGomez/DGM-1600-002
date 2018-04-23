using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Score : ScriptableObject {

    public int value;


    public void RestartScore()
    {
        value = 0;
    }


}
