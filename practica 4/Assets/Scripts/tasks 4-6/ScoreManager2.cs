using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager2 : MonoBehaviour
{
    public static int score = 0;
    public GameObject sphere1;
    public GameObject sphere2;
    void SpawnSphere(){

	Vector3 position = new Vector3(Random.Range(-8.0F, 8.0F), 1, Random.Range(-8.0F, 8.0F));
	int sphere =Random.Range(-1, 1);
    if(sphere>=0){
        Instantiate (sphere1, position, Quaternion.identity);
    }else{

        Instantiate (sphere2, position, Quaternion.identity);
    }
}
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
        SpawnSphere();
        Debug.Log("Score: " + score);
    }
}
