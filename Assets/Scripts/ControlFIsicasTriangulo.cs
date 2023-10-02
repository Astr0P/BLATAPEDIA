using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFIsicasTriangulo : MonoBehaviour
{
    public float movX, movY;
    Rigidbody2D fisicas;
    public bool puedeSaltar = false;
    public float fuerzaSalto = 10;

    // Start is called before the first frame update
    void Start()
    {
        fisicas = GetComponent<Rigidbody2D>();

        if (Input.GetButtonDown("Jump"))
        {
            puedeSaltar = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");

        //movY = Input.GetAxis("Vertical");

        Vector2 vector = new Vector2(movX, movY);

        fisicas.velocity = vector * 5;

        if (puedeSaltar == true)
        {
            fisicas.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
    }
}
