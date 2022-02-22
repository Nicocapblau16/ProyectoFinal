using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{

    public static UImanager sharedInstance;
    public TMP_InputField userNameTextBox;
 


    void Start()
    {
        string existingUserName = PlayerPrefs.GetString("userName");
        Debug.Log(existingUserName);
        if (existingUserName != "")
        {
            userNameTextBox.placeholder.GetComponent<TextMeshProUGUI>().text = existingUserName;
        }
        
    }

    public void SaveUserName()
    {
        string userName = userNameTextBox.text;

        if(userName == "")
        {
            dataPersistent.sharedInstance.userName = userNameTextBox.placeholder.GetComponent<TextMeshProUGUI>().text;
        }
        else
        {
            dataPersistent.sharedInstance.userName = userName;
        }

        PlayerPrefs.SetString("userName", dataPersistent.sharedInstance.userName);
    }

    
}
