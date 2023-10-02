using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisicasTriangulo : MonoBehaviour
{
    //int numero = 0;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = -2f;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -3)
        {
            rb.gravityScale = -1f;
        }
        else if (transform.position.y >= 3)
        {
            rb.gravityScale = 1f;
        }
    }
}
