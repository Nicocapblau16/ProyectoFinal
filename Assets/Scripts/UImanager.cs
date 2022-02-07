using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{

    public static UImanager sharedInstance;
    public TMP_InputField inputField;



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
            inputField.placeholder.GetComponent<TextMeshProUGUI>().text = existingUserName;
        }
    }

    public void SaveUserName()
    {
        string userName = inputField.text;

        if(userName == "")
        {
            dataPersistent.sharedInstance.userName = inputField.placeholder.GetComponent<TextMeshProUGUI>().text;
        }
        else
        {
            dataPersistent.sharedInstance.userName = userName;
        }

        PlayerPrefs.SetString("USER_NAME", dataPersistent.sharedInstance.userName);
    }


}
