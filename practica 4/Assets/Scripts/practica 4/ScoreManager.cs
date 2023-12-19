using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SphereGroup1"))
        {
            score += 5;
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("SphereGroup2"))
        {
            score += 10;
            Destroy(other.gameObject);
        }

        Debug.Log("Score: " + score);
    }
}
