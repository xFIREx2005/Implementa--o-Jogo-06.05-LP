using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    private Vector2 moveDirection;
    private Rigidbody2D rb;
    public float jumpForce;
    public bool isJump;
    public int life;
    public SpriteRenderer sprPlayer;

    // Start is called before the first frame update
    void Start()
    {
        sprPlayer = GetComponent<SpriteRenderer>();
        isJump = false;
        jumpForce = 7f;
        rb = GetComponent<Rigidbody2D>();
        life = 3;
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
        
            isJump = false;
        if (collision.gameObject.CompareTag("Fase2"))
        {
            SceneManager.LoadScene("Fase2");
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        
            isJump = true;
        
    
    }

    public void DamagePlayer(int damageBullet)
    {
        life -= damageBullet;
        StartCoroutine(Damage());
        if (life <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }

    }

    IEnumerator Damage()
    {
        sprPlayer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        sprPlayer.color = Color.white;
    }
}
