using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Vector2 moveDirection;
    private Rigidbody2D rb;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        jumpForce = 0.0007f;
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
         if(Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
    
}
