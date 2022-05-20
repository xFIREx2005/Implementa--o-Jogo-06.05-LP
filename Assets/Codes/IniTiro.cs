using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IniTiro : MonoBehaviour
{
    public GameObject tiro;
    public bool atira;
    // Start is called before the first frame update
    void Start()
    {
        atira = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(atira == true)
        StartCoroutine(TimerDestroy());

    }

    public IEnumerator TimerDestroy()
    {
        Instantiate(tiro, transform.position, transform.rotation);
        atira = false;
        yield return new WaitForSeconds(1);
        atira = true;
    }
}
