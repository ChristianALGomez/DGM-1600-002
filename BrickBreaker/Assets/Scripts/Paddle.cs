using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    void Update()
    {
        //get current paddle positiion
        Vector3 paddlePosition = new Vector3(0, gameObject.transform.position.y, 0);

        //get mouse horizontal position
        float mousePositionInBlocks = Input.mousePosition.x / Screen.width * 15 - 7.5f;

        paddlePosition.x = mousePositionInBlocks;


        //set this paddle ovject to saved position
        this.gameObject.transform.position = paddlePosition;

    }




}
