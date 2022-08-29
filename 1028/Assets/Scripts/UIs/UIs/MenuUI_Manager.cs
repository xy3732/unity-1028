using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Timeline;
using UnityEngine.Playables;

public class MenuUI_Manager : MonoBehaviour
{
    public TimelineAsset[] TimeLines;

    PlayableDirector pd;

    //MainMenu ¾À ¹öÆ° ¼³Á¤
    public void StartBtn()
    {
        pd = GameObject.Find("UIs").GetComponent<PlayableDirector>();

        pd.playableAsset = TimeLines[0];
        pd.Play();
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
