using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision3 : MonoBehaviour
{
    public GameObject targetObject; // The object that spheres in group 2 should orient towards
 private bool shouldMoveUp = false;

    void Update()
    {
        if (shouldMoveUp)
        {
            MoveSpheresUp();
            shouldMoveUp = false;
        }
    }

    void MoveSpheresUp()
    {
        GameObject[] spheresOfType1 = GameObject.FindGameObjectsWithTag("SphereGroup1");
        foreach (GameObject sphere in spheresOfType1)
        {
            // Change the color of spheres of the first type
            MeshRenderer sphereRenderer = sphere.GetComponent<MeshRenderer>();
            sphereRenderer.material.color = Color.yellow;
            
            // Move spheres of the first type 10 units up
            sphere.transform.Translate(Vector3.up * 1.0f);
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Cylinder"))
        {
            
            GameObject[] spheresOfType1 = GameObject.FindGameObjectsWithTag("SphereGroup1");
            foreach (GameObject sphere in spheresOfType1)
            {
                // Change the color of spheres of the first type
                MeshRenderer sphereRenderer = sphere.GetComponent<MeshRenderer>();
                sphereRenderer.material.color = Color.yellow;
                shouldMoveUp = true;
            }

            GameObject[] spheresOfType2 = GameObject.FindGameObjectsWithTag("SphereGroup2");
            foreach (GameObject sphere in spheresOfType2)
            {
                // Orient spheres of the second type towards the target object
                Vector3 directionToTarget = targetObject.transform.position - sphere.transform.position;
                sphere.transform.rotation = Quaternion.LookRotation(directionToTarget);
            }
        }
      
    }
}
