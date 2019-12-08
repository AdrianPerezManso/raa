using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private GameObject firstTrigger;
    private GameObject secondTrigger;
    private GameObject thirdTrigger;
    private AudioSource sonido;

    public Text text;
    public GameObject canasta;

    // Start is called before the first frame update
    void Start()
    {
        firstTrigger = gameObject.transform.GetChild(0).gameObject;
        secondTrigger = gameObject.transform.GetChild(1).gameObject;
        thirdTrigger = gameObject.transform.GetChild(2).gameObject;
        sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(Camera.main.transform.position, canasta.transform.position);
        if(distancia > 2.5f)
        {
            if (firstTrigger.GetComponent<BoxCollider>().enabled && firstTrigger.GetComponent<HasHitTrigger>().HasHit() && secondTrigger.GetComponent<HasHitTrigger>().HasHit() && !thirdTrigger.GetComponent<HasHitTrigger>().HasHit())
            {
                if (distancia > 4)
                    AddScore(2);
                else
                    AddScore(1);

               
                firstTrigger.GetComponent<BoxCollider>().enabled = false;
                Invoke("EnableTrigger", 1f);
            }
        }
        
    }

    void AddScore(int puntos)
    {
        if (!sonido.isPlaying)
        {
            sonido.Play();
        }
        Puntuacion.puntuacion += puntos;
        text.text = "Puntos: " + Puntuacion.puntuacion;
        
    }

    void EnableTrigger()
    {
        firstTrigger.GetComponent<BoxCollider>().enabled = true;
    }
}

public static class Puntuacion
{
    public static int puntuacion;
}
