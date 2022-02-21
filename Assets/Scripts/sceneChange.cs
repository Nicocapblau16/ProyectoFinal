using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{

    public void GoToTutorialScene()
    {
        
        SceneManager.LoadScene("Tutorial");
    }

    public void GoToPlayerNameScene()
    {
        SceneManager.LoadScene("PlayerName");
    }

    public void GoToMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }


}
