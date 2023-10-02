using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlesTriangulo2 : MonoBehaviour
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

        if (Input.GetKeyDown(KeyCode.G))
        {
            float escalaX = transform.localScale.x;
            float escalaY = transform.localScale.y;
            float escalaZ = transform.localScale.z;
            transform.localScale = new Vector3(escalaX + 1, escalaY + 1, escalaZ + 1);
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            float escalaX = transform.localScale.x;
            float escalaY = transform.localScale.y;
            float escalaZ = transform.localScale.z;
            transform.localScale = new Vector3(escalaX -1, escalaY -1, escalaZ -1);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            transform.Rotate(Vector3.forward * -10);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            transform.Rotate(Vector3.forward * 10);
        }
    }
}
