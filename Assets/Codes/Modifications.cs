using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modifications : MonoBehaviour
{
    public GameObject objMod;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero, 9);

            
            if (hit.collider != null)
            {
                objMod = hit.collider.gameObject;
                if (objMod.gameObject.CompareTag("mod")){}
                else objMod = null;
                
            }
        }
        if (objMod != null)
        {
            float minScaleY = 0.5f;
            float maxScaleY = 5f;
            float minScaleX = 0.5f;
            float maxScaleX = 5f;
            float scaleY = objMod.transform.localScale.y;
            float scaleX = objMod.transform.localScale.x;

            if (Input.GetKey(KeyCode.RightArrow) && scaleX <= maxScaleX)
            {
                
                float scale = 0.05f;
                objMod.transform.localScale += new Vector3(scale/2, 0, 0);
        
            }
            if (Input.GetKey(KeyCode.LeftArrow) && scaleX >= minScaleX)
            {
                float scale = 0.01f;
                objMod.transform.localScale += new Vector3(-scale * 2, 0, 0);

            }
            if (Input.GetKey(KeyCode.UpArrow) && scaleY <= maxScaleY)
            {
                float scale = 0.01f;
                objMod.transform.localScale += new Vector3(0, scale * 2, 0);

            }
            if (Input.GetKey(KeyCode.DownArrow) && scaleY >= minScaleY)
            {
                float scale = 0.01f;
                objMod.transform.localScale += new Vector3(0, -scale * 2, 0);

            }
            
        }
    }
}
