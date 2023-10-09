using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1;
    AudioSource FX;

    // Start is called before the first frame update
    void Start()
    {
        FX = GameObject.Find("RoachPickUp").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FX.Play();
            Destroy(gameObject);
            
            End.instance.IncreaseCoins(value);

        }
            
    }
}
