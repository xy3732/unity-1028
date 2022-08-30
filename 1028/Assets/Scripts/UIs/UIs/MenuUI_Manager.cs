using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Timeline;
using UnityEngine.Playables;

public class MenuUI_Manager : MonoBehaviour
{
    public TimelineAsset[] TimeLines;

    PlayableDirector pd;

    //MainMenu �� ��ư ����

    //���� ��ư
    public void StartBtn()
    {
        pd = GameObject.Find("UIs").GetComponent<PlayableDirector>();

        pd.playableAsset = TimeLines[0];
        pd.Play();
    }

    //���� ��ư
    public void SettingsBtn()
    {
        Debug.Log("Option");
    }

    //Exit Game ��ư
    //���� ���� �ڽ�â���� Yes�� No ��ư�߿� No��ư���� ���� �ִ�.
    public void ExitBoxCont_Btn(GameObject _exitobj)
    {
        if(_exitobj.activeSelf == false)
        {
            _exitobj.SetActive(true);
        }
        else
        {
            _exitobj.SetActive(false);
        }
    }

    public void Yes_Btn()
    {
        Application.Quit();
    }
}
