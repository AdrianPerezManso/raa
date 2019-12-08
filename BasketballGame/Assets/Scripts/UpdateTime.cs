using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateTime : MonoBehaviour
{
    private Text text;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        TimeSpan ts = TimeSpan.FromSeconds(timer);
        var minutes = ts.Minutes;
        var seconds = ts.Seconds;
        var fraction = ts.Milliseconds;

        if (text.tag.Equals("time"))
        {
            text.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, fraction);
            Tiempo.tiempo = text.text;
        }
            
    }
}

public static class Tiempo
{
    public static string tiempo;
}
