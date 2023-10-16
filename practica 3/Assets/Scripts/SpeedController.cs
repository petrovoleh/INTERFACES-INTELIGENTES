using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedController : MonoBehaviour
{
    public float speed = 1.0f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        float horizontalSpeed = horizontalInput * speed;
        float verticalSpeed = verticalInput * speed;

        Debug.Log($"Horizontal: {horizontalSpeed}, Vertical: {verticalSpeed}");
    }
}
