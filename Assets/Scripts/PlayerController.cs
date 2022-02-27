using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private pivotChange pivotChangeScript;

    public GameObject target;

    void Start()
    {
        
        pivotChangeScript = FindObjectOfType<pivotChange>();
        
    }

    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.right, pivotChangeScript.speed * Time.deltaTime);
    }


    private void OnTriggerEnter(Collider otherTrigger)
    {
        if (otherTrigger.gameObject.CompareTag("powerup") && !pivotChangeScript.haspowerUp)
        {
            pivotChangeScript.speed *= 2;
            pivotChangeScript.haspowerUp = true;
        }
        else if (otherTrigger.gameObject.CompareTag("powerdown") && pivotChangeScript.haspowerUp)
        {
            pivotChangeScript.speed /= 2;
            pivotChangeScript.haspowerUp = false;
        }
    }
}
