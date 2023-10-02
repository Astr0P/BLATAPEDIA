using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlesCuadrado : MonoBehaviour
{
    public int velocidad = 2;
    bool haciaArriba = true;

    // Start is called before the first frame update
    void Start()
    {
        //Vector2 nuevaPosicion = new Vector2(10f, -5f);
        //transform.position = nuevaPosicion;

        //transform.rotation = new Vector3(0, 0, 180);

        //transform.localScale = new Vector2(5,5);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 7)
        {
            haciaArriba = true;
        }
        else if (transform.position.y < 0)
        {
            haciaArriba = false;
        }

        if (haciaArriba == true)
        {
            transform.Translate(velocidad * Vector2.up * Time.deltaTime);
        }
        else
        {
            transform.Translate(velocidad * Vector2.down * Time.deltaTime);
        }
        //Vector2 vectorDerecha = new Vector2(2, 0);
        //transform.Translate(velocidad * Vector2.up * Time.deltaTime);
        //transform.Rotate(Vector3.forward * 45 * Time.deltaTime);
    }
}
