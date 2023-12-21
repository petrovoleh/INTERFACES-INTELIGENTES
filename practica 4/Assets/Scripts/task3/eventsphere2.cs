using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventsphere2 : MonoBehaviour
{
    public Notifier3 notif;
    private GameObject cube;
    private GameObject object_to_point;
    private GameObject[] spheres2;
    
    // Start is called before the first frame update
    void Start()
    {
      cube = GameObject.FindGameObjectWithTag("Cylinder");
      spheres2 = GameObject.FindGameObjectsWithTag("SphereGroup2");
      object_to_point = GameObject.FindGameObjectWithTag("Cylinder");

      notif = GameObject.FindGameObjectWithTag("Cylinder").GetComponent<Notifier3>();
      notif.OnCubeApproach += PointTowardsCapsule;    
    }

    void PointTowardsCapsule() {
      float distance_to_object = Vector3.Distance(cube.transform.position, object_to_point.transform.position);
      Vector3 diretion_to_object = Vector3.Normalize(object_to_point.transform.position - cube.transform.position);
      float space = distance_to_object / (spheres2.Length);

      Vector3 new_position;
      for (int i = 0; i < spheres2.Length; i++) {
        new_position = cube.transform.position + diretion_to_object * ((i + 1) * space);
        spheres2[i].GetComponent<Rigidbody>().MovePosition(new_position);
      }
    }
}
