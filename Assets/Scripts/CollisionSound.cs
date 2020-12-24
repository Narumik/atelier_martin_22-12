using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSound : MonoBehaviour
{
    public AudioSource collisionSound;

    void OnTriggerEnter(Collider target)
    {
        if(target.tag == "Item"){
            collisionSound.Play();
        }
    }
}