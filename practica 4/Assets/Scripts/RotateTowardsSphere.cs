using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsSphere : MonoBehaviour
{
    public Transform targetSphere;

    void Update()
    {
        transform.LookAt(targetSphere);
    }
}
