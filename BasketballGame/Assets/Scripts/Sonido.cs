﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{ 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
       if(!collision.gameObject.GetComponent<AudioSource>().isPlaying)
            collision.gameObject.GetComponent<AudioSource>().Play();
    }
}