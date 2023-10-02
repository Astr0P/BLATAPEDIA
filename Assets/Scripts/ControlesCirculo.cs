using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlesCirculo : MonoBehaviour
{
    public float movX, movY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");

        Vector2 direccion = new Vector2(movX, movY);

        transform.Translate(direccion * Time.deltaTime * 10);

       //nput.GetKeyDown(KeyCode.0);
    }
}
