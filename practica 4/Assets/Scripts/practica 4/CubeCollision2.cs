using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("SphereGroup1"))
        {
            GameObject[] sphereObjects = GameObject.FindGameObjectsWithTag("SphereGroup2");
            foreach (GameObject sphereObject in sphereObjects)
                {
                    Vector3 newScale = sphereObject.transform.localScale * 1.2f;
                    sphereObject.transform.localScale = newScale;
                }
            
        }
        else 
        {
            GameObject[] cylinders = GameObject.FindGameObjectsWithTag("Cylinder");
            GameObject[] sphereObjects = GameObject.FindGameObjectsWithTag("SphereGroup1");
            foreach (GameObject sphereObject in sphereObjects)
                {
                    
                     Vector3 directionToCylinder = cylinders[1].transform.position - sphereObject.transform.position;
                float speed = 2.0f; // Adjust the speed as needed
                sphereObject.transform.Translate(directionToCylinder.normalized * speed * Time.deltaTime);
          } }
    }
}
