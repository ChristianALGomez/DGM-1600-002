using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class CameraMovment : MonoBehaviour {

    public GameObject player;

    public Vector3 offset;

    
   private void Start()
    {
       // new vector3 (0 + offset.x, 0 + offset.y, 0);

        //offset = transform.position - player.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
    
}
