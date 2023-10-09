using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHoriz : MonoBehaviour
{
    bool direccionDerecha = true;
    // Start is called before the first frame update
    void Start()
    {
        direccionDerecha = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 21)
        {
            direccionDerecha = true;
        }
        if (transform.position.x > 31)
        {
            direccionDerecha = false;
        }
        
        if (direccionDerecha == true)
        {
            transform.Translate(Vector2.right * Time.deltaTime * 2);
        }
        else if (direccionDerecha == false)
        {
            transform.Translate(Vector2.left * Time.deltaTime * 2);
        }
    }
}
