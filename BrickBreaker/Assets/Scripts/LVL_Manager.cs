using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LVL_Manager : MonoBehaviour {
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void Ending(string endscreen)
    {
        SceneManager.LoadScene(endscreen);
    }

}
