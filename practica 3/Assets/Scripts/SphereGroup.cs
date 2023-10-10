using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereGroupOperations : MonoBehaviour
{
    public string groupTag; // Set this tag in the Inspector for the second group.
    public float yOffset = 2f; // Increase the height of the nearest sphere.
    public Color newColor = Color.blue; // Change color of the farthest sphere.

    private Transform cubeTransform;
    private Transform nearestSphere;
    private Transform farthestSphere;

    private void Start()
    {
        GameObject[] spheres = GameObject.FindGameObjectsWithTag(groupTag);
        cubeTransform = GameObject.FindGameObjectWithTag("Cube").transform;
        float minDistance = Mathf.Infinity;
        float maxDistance = 0f;

        foreach (GameObject sphere in spheres)
        {
            float distance = Vector3.Distance(sphere.transform.position, cubeTransform.position);

            if (distance < minDistance)
            {
                minDistance = distance;
                nearestSphere = sphere.transform;
            }

            if (distance > maxDistance)
            {
                maxDistance = distance;
                farthestSphere = sphere.transform;
            }
        }

        if (nearestSphere != null)
        {
            nearestSphere.position += Vector3.up * yOffset;
        }


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Change color of the farthest sphere when space key is pressed.
            if (farthestSphere != null)
            {
                Renderer farthestRenderer = farthestSphere.GetComponent<Renderer>();
                farthestRenderer.material.color = newColor;
            }
        }
    }
}
