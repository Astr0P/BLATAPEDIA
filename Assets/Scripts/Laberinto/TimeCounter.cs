using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimeCounter : MonoBehaviour
{
    public TMP_Text timer;
    public float time = 60;

    // Start is called before the first frame update
    void Start()
    {
        timer.text = "Tiempo: 60";
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timer.text = "Tiempo: " + ((int)time).ToString();
        if (time <= 0f)
        {
            UnityEditor.EditorApplication.isPlaying = false;

        }
    }
}
