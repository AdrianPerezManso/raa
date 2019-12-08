using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject ball;
    public Cloth cloth;

    private GameObject clone;

    public void SpawnBall()
    {
        clone  = Instantiate(ball, new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - 0.117f, Camera.main.transform.position.z + 0.35f), Quaternion.identity);


        clone.GetComponent<Rigidbody>().isKinematic = true;

        var colliders = new ClothSphereColliderPair[1];
        colliders[0] = new ClothSphereColliderPair(clone.GetComponent<SphereCollider>());

        cloth.sphereColliders = colliders; 
    }

}

