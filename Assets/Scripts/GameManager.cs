using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool isInTheGame;
    public static GameManager sharedInstance;

    public AudioSource beatTutorial;


    public GameObject menuGameOver;



    
    void Start()
    {
        

        beatTutorial = GetComponent<AudioSource>(); //musiquita

        //control de menús y corrutinas 
        menuGameOver.SetActive(false);
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        isInTheGame = false;
        
        StartCoroutine(StartCounterOf3());

         

    }


    // corrutina cuenta atrás e inicio del juego
    private IEnumerator StartCounterOf3()
    {
        TMP_Text text = GameObject.FindGameObjectWithTag("Counter").GetComponent<TMP_Text>();

        for(int i = 3; i >=0; i--)
        {
            text.SetText($"{i}");
            yield return new WaitForSeconds(1f);
        }

        isInTheGame = true;

        var panel = GameObject.Find("counterpanel");
        panel.SetActive(false);
        beatTutorial.Play();
    }


    //corrutina para que aparezca el panel de game over
    public IEnumerator GameOverPanelPopUp()
    {
        for (int a = 2; a >= 0; a--)
        {
            yield return new WaitForSeconds(1f);
            menuGameOver.SetActive(true);
            beatTutorial.Stop();

        }
    }
}
