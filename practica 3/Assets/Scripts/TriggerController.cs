using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            TriggerFunction();
        }
    }

    void TriggerFunction()
    {
        Debug.Log("Trigger Functio");
    }
}
