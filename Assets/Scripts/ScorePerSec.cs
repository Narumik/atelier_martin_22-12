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

    public float elapsedTime =0f;

    public float max_time = 10.0f;
    public float time = 0.0f;
    uint time_mul = 0;
  
    public AudioSource collectSound;
    void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerSec = 1f;
        
    }
    void Update()
    {
        scoreText.text = "SCORE: " + (int)scoreAmount;
        //elapsedTime += Time.deltaTime;
        scoreAmount = time;
        // scoreAmount +=pointIncreasedPerSec * Time.deltaTime;
        // Calculate time.
        time = (Time.time - (max_time * time_mul));
        Debug.Log(time);
        // Time is up.
        if(time >= max_time) {
            // Do whatever:
            
            // Reset time.
            time = 0.0f;
            time_mul ++;
        }
    }
    
    void OnTriggerEnter(Collider other){
        collectSound.Play();
        highScoreAmount = scoreAmount;
        highScore.text = "HIGH SCORE: " + (int)highScoreAmount;
        elapsedTime = 0f;
        
        //highScore.GetComponent<Text>().text = "HIGH SCORE: " + scoreAmount;
    }

    
}
