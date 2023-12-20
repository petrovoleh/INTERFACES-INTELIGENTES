using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notifier : MonoBehaviour
{
    public delegate void message();
    public event message OnCylinderCollision;
    void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.CompareTag("Cylinder")) {
            OnCylinderCollision?.Invoke();
        }
    }
}
