using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LapManager : MonoBehaviour
{
    private ScoreManager theScoreManager;
    public AudioSource collectSound;
    void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
    }
    void OnTriggerEnter(Collider other){
        collectSound.Play();
        theScoreManager.scoreIncreasing = false;

        if (theScoreManager.scoreCount > theScoreManager.hiScoreCount)
        {
            theScoreManager.hiScoreCount = theScoreManager.scoreCount;
            PlayerPrefs.SetFloat("BestLap", theScoreManager.hiScoreCount);
        }
        
        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }
        
}
