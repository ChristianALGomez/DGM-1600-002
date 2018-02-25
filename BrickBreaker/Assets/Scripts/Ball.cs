using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public AudioClip hitsound;
    public Vector2 startSVector;

    private void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(startSVector, ForceMode2D.Force);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(hitsound, new Vector3(0, 0, 0));//collision.transform.position);
    }

}
