
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scena : MonoBehaviour
{

    public string cenaName;
    public bool apertaTroca;

    private void Update()
    {
        if(apertaTroca == true && Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene(cenaName);
        }
    }

    public void Play()
    {
        cenaName = "Fase1";
        SceneManager.LoadScene(cenaName);
    }

    public void Exit()
    {
        Application.Quit();
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
                    SceneManager.LoadScene(cenaName);
                }
            }

        }
    }


}
