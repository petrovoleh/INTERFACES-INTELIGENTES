using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision2 : MonoBehaviour
{
    private Rigidbody rb;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cylinder"))
        {
            GameObject[] spheresOfType1 = GameObject.FindGameObjectsWithTag("SphereGroup1");
            foreach (GameObject sphere in spheresOfType1)
            {
                // Change the color of spheres of the first type
                MeshRenderer sphereRenderer = sphere.GetComponent<MeshRenderer>();
                sphereRenderer.material.color = Color.yellow;
            }
        }
    }
}
