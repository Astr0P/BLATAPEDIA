using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlesPlayer : MonoBehaviour
{
    float movX, movY;
    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        Vector2 movimiento = new Vector2(movX, movY);
        transform.Translate(movimiento * Time.deltaTime * 10);
    }
}
