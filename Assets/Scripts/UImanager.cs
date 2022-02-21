using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{

    public static UImanager sharedInstance;
    public TMP_InputField userNameTextBox;



    private void Awake()
    {
        if(sharedInstance == null)
        {
            sharedInstance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
  


    void Start()
    {
        string existingUserName = PlayerPrefs.GetString("USER_NAME");
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

        PlayerPrefs.SetString("USER_NAME", dataPersistent.sharedInstance.userName);
    }


}
