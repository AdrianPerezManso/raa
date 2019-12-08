using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EmpezarJuego : MonoBehaviour
{
    public void Game()
    {
        Puntuacion.puntuacion = 0;
        Tiempo.tiempo = "00:00:00";
        SceneManager.LoadScene("SampleScene");
    }
}
