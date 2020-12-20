using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float HorizontalSpeed = 1;
    public float VerticalSpeed = 1;

    void FixedUpdate()

    {

        float moveHorizontal = Input.GetAxis("Vertical") * HorizontalSpeed;
        float moveVertical = = Input.GetAxis("Horizontal") * VerticalSpeed;
        Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);
        GetComponent<Rigidbody>().AddForce(movement*speed*Time.deltaTime);
    }
}
