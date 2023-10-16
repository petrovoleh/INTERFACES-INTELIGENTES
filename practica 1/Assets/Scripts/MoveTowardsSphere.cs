using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsSphere : MonoBehaviour
{
    public Transform targetSphere;
    public float moveSpeed = 2.0f;

    void Update()
    {
        Vector3 direction = targetSphere.position - transform.position;
        Vector3 movement = direction.normalized * moveSpeed * Time.deltaTime;

        transform.Translate(movement);
    }
}
