using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToObjects : MonoBehaviour
{
    public string cubeTag = "Cube"; // Set the tag of the cube in the Inspector.
    public string cylinderTag = "Cylinder"; // Set the tag of the cylinder in the Inspector.

    private Transform cubeTransform;
    private Transform cylinderTransform;

    private void Start()
    {
        // Find the cube and cylinder objects by their tags.
        GameObject cubeObject = GameObject.FindWithTag(cubeTag);
        GameObject cylinderObject = GameObject.FindWithTag(cylinderTag);

        // Get the Transform components of the cube and cylinder.
        cubeTransform = cubeObject.transform;
        cylinderTransform = cylinderObject.transform;

        // Calculate the distance between the sphere and the cube and cylinder.
        float distanceToCube = Vector3.Distance(cylinderTransform.position, cubeTransform.position);

        // Display the distances in the console.
        Debug.Log("Distance betwen Cube and Cylinder: " + distanceToCube);

    }
}
