using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;

    private Rigidbody playerRigidbody;

    //public GameObject powerUp;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        playerRigidbody.AddForce(Vector3.right * speed * horizontalInput);
        playerRigidbody.AddForce(Vector3.forward * speed * verticalInput);
    }

   /* private void OnTriggerEnter(Collider otherTrigger)
    {
        if (otherTrigger.gameObject.CompareTag("powerup"))
        {

        }
        else if (otherTrigger.gameObject.CompareTag("powerdown"))
        {

        }
    }*/
}
