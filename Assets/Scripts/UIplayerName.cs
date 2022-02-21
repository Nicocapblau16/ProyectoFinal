using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIplayerName : MonoBehaviour
{
    public void GoToMainMenuScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
