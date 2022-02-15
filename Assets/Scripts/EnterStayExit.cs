using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterStayExit : MonoBehaviour
{
    public GameObject bola;

    private bool inCollider;
    private float distanceToCenter;

      

    void Update()
    {
        if (inCollider && Input.GetKeyDown(KeyCode.Space))
        {
            bola.transform.position = transform.position;
            if (distanceToCenter < 2.5f)
            {
                Debug.Log("Perf");
            }
            if (distanceToCenter < 5f)
            {
                Debug.Log("Nice");
            }
            else
            {
                Debug.Log("Good");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        bola = other.gameObject;
        Debug.Log("entro");
        inCollider = true;
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("estoy");
        distanceToCenter = Vector3.Distance(transform.position, other.transform.position);
    }

    private void OnTriggerExit(Collider other)
    {
        inCollider = false;
        Debug.Log("GameOver");
    }
}
