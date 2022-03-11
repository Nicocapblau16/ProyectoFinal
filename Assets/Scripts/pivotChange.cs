using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pivotChange : MonoBehaviour
{
    public GameObject ball01;
    public GameObject ball02;
    public GameObject movingBall;
    public bool ballMoving = true;

    public float speed = 200f;

    public GameObject FloatingTextPrefab;

    private AudioSource audioHit;

    public AudioClip hitClip;

    private void ChangePivot()
    {

        ball01.GetComponent<PlayerController>().enabled = ballMoving;
        ball02.GetComponent<PlayerController>().enabled = !ballMoving;

        movingBall = ball01.GetComponent<PlayerController>().enabled ? ball01 : ball02;
        
    }



    void Start()
    {
        ballMoving = false;
        ChangePivot();
        audioHit = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (!GameManager.sharedInstance.isInTheGame)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerController mbPC = movingBall.GetComponent<PlayerController>();
           audioHit.PlayOneShot(hitClip, 0.5f);  

            if (mbPC.inCollider)
            {
                movingBall.transform.position = mbPC.casilla.transform.position;


                mbPC.casilla.GetComponent<SphereCollider>().enabled = false;

                if (mbPC.distanceToCenter < 2.5f)
                {
                    Debug.Log("Perf");
                 //   ShowFloatingText(300); //casi
                }
                if (mbPC.distanceToCenter < 5f)
                {
                    Debug.Log("Nice");
                   // ShowFloatingText(200);
                }
                else
                {
                    Debug.Log("Good");
                    //ShowFloatingText(100);
                }
            }
            else
            {

                mbPC.GoToGameOver();
            }

            ballMoving = !ballMoving;
            ChangePivot();

        }
    }
   /* void ShowFloatingText(float score)
    {
        var go = Instantiate(FloatingTextPrefab, transform.position, Quaternion.identity, transform);
        go.GetComponent<TextMesh>().text = score.ToString();
    }
   */
    
}
