using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision2 : MonoBehaviour
{
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

            GameObject[] spheresOfType2 = GameObject.FindGameObjectsWithTag("SphereGroup2");
            foreach (GameObject sphere in spheresOfType2)
            {
                // Move spheres of the second type towards the cylinder
                Vector3 directionToCylinder = other.transform.position - sphere.transform.position;
                float speed = 2.0f; // Adjust the speed as needed
                sphere.transform.Translate(directionToCylinder.normalized * speed * Time.deltaTime);
            }
        }
    }
}
