using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{

    [SerializeField] GameObject menuPausa;

    private GameManager gmScript;
    
    void Start()
    {
        menuPausa.SetActive(false);
        gmScript = FindObjectOfType<GameManager>();
    }

    public void Pause()
    {
        // pausa
        menuPausa.SetActive(true);
        Time.timeScale = 0f;
        gmScript.beatTutorial.Pause();

    }

    public void Resume()
    {
        // continuar con el juego pausado
        menuPausa.SetActive(false);
        Time.timeScale = 1f;
        gmScript.beatTutorial.UnPause();
    }

    public void Home()
    {
        //salir al menú anterior
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void RestartScene()
    {
        //volver a empezar la partida
        SceneManager.LoadScene("Tutorial");
        Time.timeScale = 1f;
    }

}
