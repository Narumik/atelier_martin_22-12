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
        hiScoreCount = float.MaxValue;
    }

    void Update()
    {
        if(scoreIncreasing)
        {
            scoreCount += pointPerSec * Time.deltaTime;
        }

        scoreText.text = "LAP: " + Mathf.Round(scoreCount);
        hiscoreText.text = "BEST: " + Mathf.Round(hiScoreCount);
    }
}
