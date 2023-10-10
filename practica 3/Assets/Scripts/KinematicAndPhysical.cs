using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicAndPhysical : MonoBehaviour
{
    private Rigidbody cubeRigidbody;
    private Rigidbody sphereRigidbody;

    void Start()
    {
        cubeRigidbody = GetComponent<Rigidbody>();
        sphereRigidbody = GetComponent<Rigidbody>();
        
        cubeRigidbody.isKinematic = true;
        sphereRigidbody.isKinematic = false;
    }
}
