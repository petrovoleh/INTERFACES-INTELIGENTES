using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    public float moveSpeed = 2.0f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime;

        transform.Translate(movement);
    }
}
