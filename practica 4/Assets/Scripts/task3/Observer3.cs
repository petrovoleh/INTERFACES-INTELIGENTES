using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer3 : MonoBehaviour
{
    float speed;
    Notifier3 detectApproach;
    GameObject cylinder;
    void Start()
    {
        speed = 5;
        cylinder = GameObject.FindGameObjectWithTag("Cylinder");
        detectApproach = cylinder.GetComponent<Notifier3>();
        if (gameObject.tag == "SphereGroup1") {
            detectApproach.OnCubeApproach += ChangeColor;
            detectApproach.OnCubeApproach += Jump;
        }
        if (gameObject.tag == "SphereGroup2") detectApproach.OnCubeApproach += FaceTowardsCylinder;
    }

    void Update() {
        Debug.DrawRay(gameObject.transform.position, gameObject.transform.forward * 10, Color.white);
    }

    void ChangeColor() {
        Material mat = gameObject.GetComponent<Renderer>().material;
        mat.color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0.3f,1f));
    }

    void Jump() {
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,speed,0),ForceMode.VelocityChange);
    }

    void FaceTowardsCylinder() {
        gameObject.transform.LookAt(cylinder.transform);
    }
}
