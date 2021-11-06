using System;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public void StartNew()
    {
        SaveName();
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {   
        DataManager.Instance.SavePlayer(); 
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit(); // original code to quit Unity player
        #endif
    }

    public void SaveName(){
        DataManager.Instance.playerName = usernameInput.text;
    }

    public void SavePlayerClicked()
    {
        DataManager.Instance.SavePlayer();
    }

    public void LoadPlayerClicked()
    {
        DataManager.Instance.LoadPlayer();
        usernameInput.text = DataManager.Instance.playerName;
    }
}
