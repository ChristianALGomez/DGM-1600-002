using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]
public class PlayerMovement : MonoBehaviour {

    

    private Rigidbody2D rigid;
    public float speed;
    public float jumpPower;
    public bool Grounded = true;
    private Animator anim;
    private SpriteRenderer rend;


	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        //check for button pushes

        

        rigid.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0), ForceMode2D.Force);
        anim.SetFloat("HorizontalGo", Input.GetAxisRaw("Horizontal"));
        if(Input.GetAxisRaw("Horizontal") < -0.1f)
        {
            //flip sptite renderer
            rend.flipX = true;
        } else
        {
            //unflip
            rend.flipX = false;
        }
        if (Input.GetButton("Fire1"))
        {
            anim.SetTrigger("FireGo");
        }
        if (Grounded && Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(new Vector2(0, jumpPower), ForceMode2D.Force);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            Grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            Grounded = false;
        }
    }
}



