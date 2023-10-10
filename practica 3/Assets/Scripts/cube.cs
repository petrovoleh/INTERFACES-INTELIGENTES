using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRandomMovement : MonoBehaviour
{
    public int numberOfRandomValues = 10; // Change this value from the inspector.
    public int rangeMin = 0;
    public int rangeMax = 25;

    private int[] randomValues;

    private void Start()
    {
        randomValues = new int[numberOfRandomValues];
        GenerateRandomValues();
    }

    private void Update()
    {
        int randomIndex = Random.Range(0, numberOfRandomValues);
        randomValues[randomIndex] = Random.Range(rangeMin, rangeMax + 1);

        foreach (int value in randomValues)
        {
            if (value > 15)
            {
                Debug.Log(value);
            }
        }
    }

    private void GenerateRandomValues()
    {
        for (int i = 0; i < numberOfRandomValues; i++)
        {
            randomValues[i] = Random.Range(rangeMin, rangeMax + 1);
        }
    }
}
