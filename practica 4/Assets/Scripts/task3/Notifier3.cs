using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notifier3 : MonoBehaviour
{
    public delegate void message();
    public event message OnCubeApproach;

    public int range = 3;
    GameObject cube;
    bool approached = true;
    void Start()
    {
        cube = GameObject.FindGameObjectWithTag("Cube");
    }

    void Update()
    {
        if(Vector3.Distance(this.gameObject.transform.position, cube.transform.position) < range) {
            Debug.Log("jump");
            if (approached) OnCubeApproach?.Invoke();
            approached = false;
            

        } else approached = true;
    }
}
