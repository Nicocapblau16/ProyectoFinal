using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public float speed = 10.0f;

    //private Rigidbody playerRigidbody;

    //public GameObject powerUp;



    /*private void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
        playerRigidbody = GetComponent<Rigidbody>();
    }
*/
    void Start()
    {
        Time.timeScale = 1;
    }
    /*

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        playerRigidbody.AddForce(Vector3.right * speed * horizontalInput);
        playerRigidbody.AddForce(Vector3.forward * speed * verticalInput);
    }*/

    private void OnTriggerEnter(Collider otherTrigger)
    {
        if (otherTrigger.gameObject.CompareTag("powerup"))
        {
            Time.timeScale = 2f;
            
        }
        else if (otherTrigger.gameObject.CompareTag("powerdown"))
        {
            Time.timeScale = 0.5f;
        }
    }
}
