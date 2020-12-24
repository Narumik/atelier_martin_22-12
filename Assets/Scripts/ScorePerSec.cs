using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePerSec : MonoBehaviour
{
    public Text scoreText;

    public Text highScore;
    public float scoreAmount;

    public float highScoreAmount;
    public float pointIncreasedPerSec;
  
    public AudioSource collectSound;
    void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerSec = 1f;
        
    }

    void Update()
    {
        scoreText.text = "SCORE: " + (int)scoreAmount;
        scoreAmount +=pointIncreasedPerSec * Time.deltaTime;
    }
    
    void OnTriggerEnter(Collider other){
        collectSound.Play();
        highScoreAmount = scoreAmount;
        highScore.text = "HIGH SCORE: " + (int)highScoreAmount;
        //highScore.GetComponent<Text>().text = "HIGH SCORE: " + scoreAmount;
    }

    
}
