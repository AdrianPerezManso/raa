using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTiempo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         GetComponent<Text>().text = Tiempo.tiempo;
    }
}
