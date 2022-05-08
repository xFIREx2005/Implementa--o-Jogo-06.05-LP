using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Vector2 moveDirection;
    private Rigidbody2D rb;
    public float jumpForce;
    public bool isJump;

    // Start is called before the first frame update
    void Start()
    {
        isJump = false;
        jumpForce = 7f;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
         Move();
         Jump();
    }

       public void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0f,0f);
        transform.position += movement * Time.deltaTime * 4;
    }

    public void Jump()
    {
         if(Input.GetButtonDown("Jump") && isJump == false)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isJump = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJump = true;
        }
    
    } 
}
