using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnKeyPress : MonoBehaviour
{
    public KeyCode colorChangeKey = KeyCode.A;
    public Color newColor = Color.red;

    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(colorChangeKey))
        {
            renderer.material.color = newColor;
        }
    }
}
