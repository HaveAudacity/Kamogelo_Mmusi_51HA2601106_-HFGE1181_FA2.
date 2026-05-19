using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    public static void ResetScore()
    {
        score = 0;
    }
}