using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{

    [SerializeField] GameObject menuPausa;
    void Start()
    {
        menuPausa.SetActive(false);
    }

    public void Pause()
    {
        menuPausa.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        menuPausa.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Home()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu"); 
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
