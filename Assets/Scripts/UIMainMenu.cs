using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    public TextMeshProUGUI welcome;
    private void Start()
    {
        // texto de bienvenida al jugador
        welcome.text = $"WELCOME\n{dataPersistent.sharedInstance.userName}"; //sigue dando error de nul reference (?)
    }
    public void GoToTutorialScene()
    {
        //a la escena de juego
        SceneManager.LoadScene("Tutorial");
    }

    public void GoToPlayerNameScene()
    {
        //a la escena de elección de nombre de jugador
        SceneManager.LoadScene("PlayerName");
    }


}
