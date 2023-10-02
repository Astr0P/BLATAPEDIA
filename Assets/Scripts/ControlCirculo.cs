using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCirculo : MonoBehaviour
{
    public float movX, movY;
    Rigidbody2D rb;
    public float velocidad = 10f;
    float barro = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
        Vector2 movimiento = new Vector2(movX, movY);
        transform.Translate(movimiento * Time.deltaTime * velocidad);
    }
    private void OnTriggerEnter2D(Collider2D Barro)
    {
        velocidad = velocidad / barro;
    } 
    private void OnTriggerExit2D(Collider2D Barro)
    {
        velocidad = velocidad * barro;
    }

}
