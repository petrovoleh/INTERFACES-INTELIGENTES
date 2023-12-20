using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    float speed;
    GameObject cylinder;
    GameObject cube;
    Notifier detectCollision;
    void Start()
    {
        speed = 0f;
        cube = GameObject.FindGameObjectWithTag("Cube");
    
        detectCollision = cube.GetComponent<Notifier>();
        cylinder = GameObject.FindGameObjectWithTag("Cylinder");
        if (this.gameObject.tag == "SphereGroup2") detectCollision.OnCylinderCollision += IncreaseSpeed;
     }

    void FixedUpdate()
    {
        Vector3 direction = cylinder.transform.position - this.gameObject.transform.position;
        this.gameObject.GetComponent<Rigidbody>().AddForce(direction.normalized * speed * Time.deltaTime, ForceMode.Impulse);
    }

    void IncreaseSpeed() {
        speed = 5f;
    }

}
