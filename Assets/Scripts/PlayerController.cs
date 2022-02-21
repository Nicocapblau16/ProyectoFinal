using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 1;
    }


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
