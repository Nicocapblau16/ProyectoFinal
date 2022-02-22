using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pivotChange : MonoBehaviour
{
    public GameObject ball01;
    public GameObject ball02;
    public bool ballMoving = true;
    public bool haspowerUp = false;
    public float speed = 200f;

    private void ChangePivot(bool IsActive)
    {
        ball01.GetComponent<rotate>().enabled = IsActive;
        ball02.GetComponent<rotate>().enabled = !IsActive;
    }


    // Start is called before the first frame update
    void Start()
    {
        ballMoving = false;
        ChangePivot(ballMoving);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ballMoving = !ballMoving;
            ChangePivot(ballMoving);
        }
    }
}
