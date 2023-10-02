using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlesTriangulo : MonoBehaviour
{
    bool haciaDerecha = true;
    public int velocidad = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -5)
        {
            haciaDerecha = true;
        }
        else if (transform.position.x >= 5)
        {
            haciaDerecha = false;
        }

        if (haciaDerecha == true)
        {
            transform.Translate(velocidad * Vector2.right * Time.deltaTime);
            //transform.Rotate(Vector3.forward, Time.deltaTime * 45);
            float escalaX = transform.localScale.x;
            float escalaY = transform.localScale.y;
            //float escalaZ = transform.localScale.z;
            //transform.localScale = new Vector3(escalaX + 1.5f,escalaY + 1.5f, escalaZ + 1.5f * Time.deltaTime);
        }
        else if (haciaDerecha == false)
        {
            transform.Translate(velocidad * Vector2.left * Time.deltaTime);
            float escalaX = transform.localScale.x;
            float escalaY = transform.localScale.y;
            //float escalaZ = transform.LocalScale.z;
            //transform.localScale = new Vector3(escalaX - 0.5f,escalaY - 0.5f, escalaZ - 0.5f * Time.deltaTime);
        }

    }
}
