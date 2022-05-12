
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scena : MonoBehaviour
{

    public string cenaName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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

    
}
