using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float movX, movY;
    Rigidbody2D player;
    float velocidad = 5f;
    public bool stuck = false;
    float stucktimer = 0f;
    Renderer m_Renderer;

    // Start is called before the first frame update
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
        Vector2 movimiento = new Vector2(movX, movY);
        transform.Translate(movimiento * Time.deltaTime * velocidad);
        if (stuck == true)
        {
            stucktimer += Time.deltaTime;
            if (stucktimer >= 2f)
            {
                stuck = false;
                velocidad = 5f;
                m_Renderer.material.color = Color.white;
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        stuck = true;
        stucktimer = 0f;
        if (stuck == true)
        {
            velocidad = 0f;
            m_Renderer.material.color = Color.red;

        }
    }
    
}
