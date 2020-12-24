﻿using System.Collections;
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
        if(PlayerPrefs.HasKey("BestLap"))
        {
            hiScoreCount = PlayerPrefs.GetFloat("BestLap");
        }
    }

    void Update()
    {
        if(scoreIncreasing)
        {
            scoreCount += pointPerSec * Time.deltaTime;
        }

        /*if (scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("BestLap", hiScoreCount);
        }*/

        scoreText.text = "LAP: " + Mathf.Round(scoreCount);
        hiscoreText.text = "BEST: " + Mathf.Round(hiScoreCount);
    }
}
