using UnityEngine;
using UnityEngine.UI;

public class ScoreUI2 : MonoBehaviour
{
    public Text scoreText;

    void Update()
    {
        scoreText.text = "Score: " + ScoreManager.score.ToString();
    }
}
