using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PlayerControl : MonoBehaviour
{
    
    public static PlayerControl instance;
    Rigidbody2D player;
    float movX, movY;
    float velocidad = 3f;
    float stucktimer = 0f;
    bool stuck = false;
    bool small = false;
    Renderer m_Renderer;
    AudioSource FX;
    private SpriteRenderer spriteRenderer;
    private PolygonCollider2D polygonCollider;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }
    
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        FX = GameObject.Find("BumpSFX").GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        polygonCollider = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movY = Input.GetAxis("Vertical");
        Vector2 movimiento = new Vector2(movX, movY);
        transform.Translate(movimiento * Time.deltaTime * velocidad);
        if (movX > 0 && small == false)
        {
            transform.localScale = new Vector3(0.8068f, 0.8068f, 0.8068f);
        }
        else if (movX > 0 && small == true)
        {
            transform.localScale = new Vector3(0.6051f, 0.6051f, 0.6051f);
        }
        else if (movX < 0 && small == false) 
        {
            transform.localScale = new Vector3(-0.8068f, 0.8068f, 0.8068f);
        }
        else if (movX < 0 && small == true)
        {
            transform.localScale = new Vector3(-0.6051f, 0.6051f, 0.6051f);
        }
        
        if (stuck == true)
        {
            stucktimer += Time.deltaTime;
            if (stucktimer >= 2f)
            {
                stuck = false;
                velocidad = 3f;
                m_Renderer.material.color = Color.white;
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        stuck = true;
        FX.Play();
        stucktimer = 0f;
        if (stuck == true)
        {
            velocidad = 0f;
            m_Renderer.material.color = Color.red;

        }
    }

    public void MakeSmaller()
    {
        small = true;
    }
    
}
