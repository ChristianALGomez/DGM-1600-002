using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class HP : ScriptableObject {

    public int value;


    public void RestartHP()
    {
        value = 1;
    }



}
