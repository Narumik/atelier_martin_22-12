using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text hiscoreText;

    public float scoreCount;
    public float hiScoreCount;

    public float pointPerSec = 1.0f;

    public bool scoreIncreasing;
   
    void Start()
    {
        
    }

    void Update()
    {
        if(scoreIncreasing)
        {
            scoreCount += pointPerSec * Time.deltaTime;
        }

        if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
        }

        scoreText.text = "SCORE: " + Mathf.Round(scoreCount);
        hiscoreText.text = "HIGH SCORE: " + Mathf.Round(hiScoreCount);
        }
}
