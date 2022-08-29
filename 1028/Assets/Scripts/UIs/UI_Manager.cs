using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    //MainMenu ¾À ¹öÆ° ¼³Á¤
    public void StartBtn(int _waitTime)
    {
        SceneManager.LoadScene("1F");
    }

    public void SettingsBtn()
    {
        Debug.Log("Option");
    }

    public void ExitBtn()
    {
        Debug.Log("Exit");
    }
}
