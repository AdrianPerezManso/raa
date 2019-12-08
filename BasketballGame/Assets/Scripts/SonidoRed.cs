using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoRed : MonoBehaviour
{
    private AudioSource sonido;

    // Start is called before the first frame update
    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        
        if(!sonido.isPlaying)
            sonido.Play();
    }

}
