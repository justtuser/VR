using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; 

    private CharacterController characterController; 

    void Start()
    {
        characterController = GetComponent<CharacterController>(); 
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = transform.forward * verticalInput + transform.right * horizontalInput; 

        movement.y -= 9.81f * Time.deltaTime;

        characterController.Move(movement * speed * Time.deltaTime); 
    }
}
