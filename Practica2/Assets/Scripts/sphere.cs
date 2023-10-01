using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereVectorOperations : MonoBehaviour
{
    public Vector3 vectorA;
    public Vector3 vectorB;

    private void Start()
    {
        Debug.Log("Magnitude of Vector A: " + vectorA.magnitude);
        Debug.Log("Magnitude of Vector B: " + vectorB.magnitude);
        Debug.Log("Angle between Vector A and B: " + Vector3.Angle(vectorA, vectorB));
        Debug.Log("Distance between Vector A and B: " + Vector3.Distance(vectorA, vectorB));

        if (vectorA.y > vectorB.y)
        {
            Debug.Log("Vector A is at a greater height.");
        }
        else
        {
            Debug.Log("Vector B is at a greater height.");
        }
    }
}

