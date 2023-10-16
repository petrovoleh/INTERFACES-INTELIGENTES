using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public Vector3 moveDirection;
    public float speed = 2.0f;

    void Update()
    {
        Vector3 movement = moveDirection.normalized * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
