using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBarrierSound : MonoBehaviour
{
    public AudioSource barrierSound;

    void OnTriggerEnter(Collider target)
    {
        if(target.tag == "Floor"){
            barrierSound.Play();
        }
    }
}
