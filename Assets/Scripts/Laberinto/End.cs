using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class End : MonoBehaviour
{
    public static End instance;
    public GameObject panel;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public int currentCoins = 0;
    public float time = 60;
    public TMP_Text coinText;
    public TMP_Text timer;
    AudioSource BG;
    AudioSource END1;
    AudioSource END2;
    AudioSource END3;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
        BG = GameObject.Find("MusicaFondo").GetComponent<AudioSource>();
        END1 = GameObject.Find("HollowKnightBenchRestOST").GetComponent<AudioSource>();
        END2 = GameObject.Find("HollowKnightDeepnestOST").GetComponent<AudioSource>();
        END3 = GameObject.Find("HollowKnightAbyssOST").GetComponent<AudioSource>();
        panel.SetActive(false);
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        coinText.text = "Amigos: " + currentCoins.ToString();
        timer.text = "Tiempo: 60";
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        
        if (time <= 90)
        {
            timer.text = "Tiempo: " + ((int)time).ToString();
        }
        
        if (time <= 0f)
        {
            panel.SetActive(true);
            Time.timeScale = 0f;
            BG.Stop();
            END3.Play();
            time = 100;
        }
    }
    public void IncreaseCoins(int v)
    {
        currentCoins += v;

        coinText.text = "Amigos: " + currentCoins.ToString();
    }

    private void OnTriggerEnter2D(Collider2D PlayerControl)
    {
        if (currentCoins == 24) 
        {
            panel1.SetActive(true);
            Time.timeScale = 0f;
            BG.Stop();
            END1.Play();
        }
        else if (currentCoins <= 9f)
        {
            panel3.SetActive(true);
            Time.timeScale = 0f;
            BG.Stop();
            END3.Play();
        }
        else if(currentCoins <= 23f)
        {
            panel2.SetActive(true);
            Time.timeScale = 0f;
            BG.Stop();
            END2.Play();
        }
        
    }
}
