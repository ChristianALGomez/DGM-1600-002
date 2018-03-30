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
    public LayerMask groundLayer;


	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
	}


    // Update is called once per frame
    void Update () {

        //check for button pushes
        //player movment
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
        //attack animation by clicking right button or ctrl
        if (Input.GetButton("Fire1"))
        {
            anim.SetTrigger("FireGo");
        }
        //Jump
        if (Input.GetButtonDown("Jump"))
        {

            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 10.0f, 9);
            if (hit.collider != null) {
                
            if (hit.collider.tag == "Ground")
                {
                    Grounded = true;
                    Debug.Log("found ground");
                }
                else
                {
                    Grounded = false;
                    Debug.Log("no ground");
                }
            }

            if (Grounded)
            {
                rigid.AddForce(new Vector2(0, jumpPower), ForceMode2D.Force);
            }
        }
    }


    /*bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;

        Debug.DrawRay(position, direction, Color.green);
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;

    }*/

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



