using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIplayerName : MonoBehaviour
{
    public TMP_InputField userNameIF;


    void Start()
    {
        string existingUserName = PlayerPrefs.GetString("userName");
        if (existingUserName != "")
        {
            userNameIF.placeholder.GetComponent<TextMeshProUGUI>().text = existingUserName;
        }

    }
    public void GoToMainMenuScene()
    {

        string userName = userNameIF.text;
        if (userName == "")
        {
            dataPersistent.sharedInstance.userName = userNameIF.placeholder.GetComponent<TextMeshProUGUI>().text;
        }
        else
        {
            dataPersistent.sharedInstance.userName = userName;
        }

        PlayerPrefs.SetString("userName", dataPersistent.sharedInstance.userName);
    


        SceneManager.LoadScene("MainMenu");


    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }


}
