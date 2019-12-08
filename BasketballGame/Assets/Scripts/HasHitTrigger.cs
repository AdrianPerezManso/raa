using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasHitTrigger : MonoBehaviour
{
    private bool hasHit = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("bola"))
        {
            hasHit = true;
            Invoke("NoHit", 0.2f);                
        }
    }

    public bool HasHit()
    {
        return hasHit;
    }

    public void NoHit()
    {
        hasHit = false;
    }
}
