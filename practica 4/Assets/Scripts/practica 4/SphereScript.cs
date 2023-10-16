using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public bool isGroup1;

    void Update()
    {
        if (isGroup1)
        {
            // Приближение сферы 1 к цилиндру
            if (Vector3.Distance(transform.position, GameObject.Find("Cylinder").transform.position) < 5f)
            {
                // Изменение цвета и прыжок
                MeshRenderer sphereRenderer = GetComponent<MeshRenderer>();
                sphereRenderer.material.color = Color.green;
                transform.Translate(Vector3.up * 0.1f);
            }
        }
        else
        {
            // Ориентирование на объект
            transform.LookAt(GameObject.Find("TargetObject").transform);
        }
    }
}
