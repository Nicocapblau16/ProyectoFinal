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
        welcome.text = $"WELCOME\n{dataPersistent.sharedInstance.userName}";
    }
    public void GoToTutorialScene()
    {

        SceneManager.LoadScene("Tutorial");
    }

    public void GoToPlayerNameScene()
    {
        SceneManager.LoadScene("PlayerName");
    }

}
