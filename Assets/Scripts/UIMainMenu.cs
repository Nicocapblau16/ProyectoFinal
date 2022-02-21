using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainMenu : MonoBehaviour
{
    public void GoToTutorialScene()
    {

        SceneManager.LoadScene("Tutorial");
    }

    public void GoToPlayerNameScene()
    {
        SceneManager.LoadScene("PlayerName");
    }

}
