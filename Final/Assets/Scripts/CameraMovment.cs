using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class CameraMovment : MonoBehaviour {

    public GameObject player;
    public static CameraMovment instance = null;
    public Vector3 offset;

    void Awake()
    {

        //Singleton
        if (instance == null)  //if instance is not assigned
        {
            instance = this;  //then assign instance to this object
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);  //then destroy this object
        }
    }
    private void Start()
    {
       // new vector3 (0 + offset.x, 0 + offset.y, 0);

        //offset = transform.position - player.transform.position;
    }

    private void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.transform.position + offset;
        }
        
    }
    
    
}
