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
    public string playerName;
    public TMP_InputField usernameInput;
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit(); // original code to quit Unity player
        #endif
    }

    public void SaveName(){
        playerName = usernameInput.text;
        Debug.Log(playerName);
    }
}
