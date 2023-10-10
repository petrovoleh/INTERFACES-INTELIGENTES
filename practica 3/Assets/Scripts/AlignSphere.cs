using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AlignSphere : MonoBehaviour
{
    public Transform Sphere;
    public float offsetX = 5f;

    private void Update()
    {
        Vector3 newPosition = Sphere.position;

        // Align Cylinder to the right and Cube to the left of the Sphere
        transform.position = new Vector3(newPosition.x + offsetX, newPosition.y, newPosition.z);
    }
}
