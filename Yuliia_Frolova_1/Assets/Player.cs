using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{

    public float speed = 500;
    public float jumpSpeed = 400;
    private Rigidbody2D rb;
    private float xDisplacement;
    private bool isGrounded;
  
    void Start(){

        rb = GetComponent<Rigidbody2D>();
        isGrounded = false;
    }

  
    void Update(){

        xDisplacement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector2 vector = new Vector2(xDisplacement, rb.velocity.y);
        rb.velocity = vector;

        if(Input.GetKeyDown("space"))
        {
            if (isGrounded == true)
            {
                rb.AddForce(new Vector2(0, jumpSpeed));
                isGrounded = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
}
