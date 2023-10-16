using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLogger : MonoBehaviour
{
    void Start()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        
        foreach (GameObject obj in allObjects)
        {
            Debug.Log("Object in scene: " + obj.name);
        }
    }
}
