using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{

    private GameManager gmScript;

    private PlayerController PcScript;


    void Start()
    {
        gmScript = FindObjectOfType<GameManager>();
        PcScript = FindObjectOfType<PlayerController>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            // acabar el juego
            gmScript.isInTheGame = false;
            PcScript.GoToGameOver();
            
        }
    }
}
