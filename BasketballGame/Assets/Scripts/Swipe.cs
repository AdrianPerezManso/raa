
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    Vector2 startPos, endPos, direction;
    float touchTimeStart, touchTimeFinish, timeInterval;

    private bool once = true;

    [SerializeField]
    float throwForceInXAndY = 0.01f;

    [SerializeField]
    float throwForceInZ = 0.01f;

    private Rigidbody rb;

    public Spawn spawn;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                touchTimeStart = Time.time;
                startPos = Input.touches[0].position;
            }
            if (Input.touches[0].phase == TouchPhase.Ended)
            {

                touchTimeFinish = Time.time;
                timeInterval = touchTimeFinish - touchTimeStart;
                endPos = Input.touches[0].position;
                direction = endPos - startPos;
                rb.isKinematic = false;
                rb.AddForce(direction.x * throwForceInXAndY, direction.y * throwForceInXAndY, throwForceInZ / timeInterval);
                if (once)
                    spawn.Invoke("SpawnBall", 1f);
                once = false;
                Destroy(this.gameObject, 4f);
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {
            touchTimeStart = Time.time;
            startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            touchTimeFinish = Time.time;
            timeInterval = touchTimeFinish - touchTimeStart;
            endPos = Input.mousePosition;
            direction = endPos - startPos;
            rb.isKinematic = false;
            rb.AddForce(direction.x * throwForceInXAndY, direction.y * throwForceInXAndY * 2, throwForceInZ / timeInterval);
            if (once)
                spawn.Invoke("SpawnBall", 1f);
            once = false;
            Destroy(this.gameObject, 4f);
        }
    }
    
}
