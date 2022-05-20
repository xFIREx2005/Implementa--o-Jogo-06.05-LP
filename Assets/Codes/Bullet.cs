using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public bool righ;

    void Update()
    {
        if (righ == true)
        transform.Translate(Vector3.right * Time.deltaTime * 10);
        else
        transform.Translate(Vector3.right * Time.deltaTime * -10);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.CompareTag("Player"))
            {
                PlayerController player = collision.GetComponent<PlayerController>();
                if (player != null)
                {
                    player.DamagePlayer(1);
                    Destroy(gameObject);
                }
            }
            Destroy(gameObject);

        }
        if (collision.gameObject.tag == "Colisao") Destroy(gameObject);
    }
}
