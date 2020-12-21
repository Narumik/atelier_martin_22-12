using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyPlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Rigidbody playerBody;

    public CharacterController controller;
    public Transform cam;

    

    private Vector3 inputVector;
    void Start()
    {
        playerBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        inputVector = new Vector3(Input.GetAxis("Horizontal")*10, playerBody.velocity.y, Input.GetAxis("Vertical")*10);
        transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));

        float targetAngle = Mathf.Atan2(inputVector.x, inputVector.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

        Vector3 moveDir = Quaternion.Euler(0f, targetAngle,0f)*Vector3.forward;
        controller.Move(moveDir.normalized*6f*Time.deltaTime);
    }

    private void FixedUpdate()
    {
        playerBody.velocity = inputVector;
    }

}
