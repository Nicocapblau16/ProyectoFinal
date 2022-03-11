using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private pivotChange pivotChangeScript;

    public GameObject target;

    public ParticleSystem explosionParticleSystem;

    private Animator ball01Death;


    public bool inCollider;
    public float distanceToCenter;

    public GameObject casilla;


    void Start()
    {
       
        pivotChangeScript = FindObjectOfType<pivotChange>();
        //ball01Death = GetComponent<Animator>();
        ball01Death.SetBool("IsDead", false);
        
    }

    private void OnEnable()
    {
        inCollider = false;
    }

    void Update()
    {
        //rotación
        if(GameManager.sharedInstance.isInTheGame)
            transform.RotateAround(target.transform.position, Vector3.right, pivotChangeScript.speed * Time.deltaTime);

        
    }

    //power up y entrada en la casilla
    private void OnTriggerEnter(Collider otherTrigger)
    {
        if (!GameManager.sharedInstance.isInTheGame)
            return;

        if (otherTrigger.gameObject.CompareTag("powerup")) 
        {
            
            
            pivotChangeScript.speed *= 2;


        }
        else if (otherTrigger.gameObject.CompareTag("powerdown"))
        {

            pivotChangeScript.speed /= 2;


        }
        if (otherTrigger.gameObject.CompareTag("Tile"))
        {

            casilla = otherTrigger.gameObject;

            inCollider = true;
        }
    }

    // estancia en la casilla
    private void OnTriggerStay(Collider otherTrigger)
    {
        if (otherTrigger.gameObject.CompareTag("Tile"))
        {
            inCollider = true;

            distanceToCenter = Vector3.Distance(transform.position, otherTrigger.transform.position);
        }
            
    }

    //salida de la casilla (perder)
    private void OnTriggerExit(Collider otherTrigger)
    {
        if (otherTrigger.gameObject.CompareTag("Tile"))
        {
            inCollider = false;
            
            GoToGameOver();
        }


    }

    //funcion de perder
    public void GoToGameOver()
    {
        GameManager.sharedInstance.isInTheGame = false;

        StartCoroutine(GameManager.sharedInstance.GameOverPanelPopUp());
        Instantiate (explosionParticleSystem, pivotChangeScript.movingBall .transform.position, Quaternion.identity);

    }
}
