using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ObjectEventTriger : MonoBehaviour
{
    public GameObject TrigerAbleUI;

    GameManager gameManager;
    EventStatus eventSelection;
    TextManager textmanager;

    int talkindex;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        textmanager = GameObject.Find("TextManager").GetComponent<TextManager>();
    }

    private void Start()
    {
        TrigerAbleUI.SetActive(false);
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("EventTriger"))
        {
            //트리거 UI를 게임오브젝트 위에 표시 && 범위 내에 상호작용 오브젝트가 있을시 활성화
            #region TrigrUI
            TrigerAbleUI.SetActive(true);

            TrigerAbleUI.transform.position = Camera.main.WorldToScreenPoint(other.transform.position + new Vector3(0, 0.9f, 0));
            #endregion

            #region Triger
            if (Input.GetKey(KeyCode.E)) ClickTriger(other);
            #endregion

        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("EventTriger"))
        {
            //트리거 UI  범위 에서 나가면 비활성화
            #region TrigrUI
            TrigerAbleUI.SetActive(false);
            #endregion
        }
    }

    void ClickTriger(Collider other)
    {
        //딜레이중이라면 반환.
        if (gameManager.isDelayOn == true) return;

        //현재 충돌한 오브젝트의 이벤트 타입을 가져옵니다.
        eventSelection = other.gameObject.GetComponent<EventStatus>();

        GetText(eventSelection.ID, eventSelection.isCharaTalk);
        //여러번 클릭하는걸 막기 위해서 딜레이 주기 [1.5초]
        StartCoroutine(gameManager.DelayTimer(1.5f));

        Debug.Log("check");
    }

    void GetText(int id, bool isCharaTalk)
    {
        Debug.Log(id);
        string textData = textmanager.GetTalk(id, talkindex);

        if (textData == null)
        {
            textmanager.isText = false;
            talkindex = 0;
            textmanager.TalkCon();
            return;
        }

        if (isCharaTalk)
        {
            textmanager.DescText.text = textData.Split(':')[0];
            textmanager.CharaFace_Img.sprite = textmanager.GetPortrait(id, int.Parse(textData.Split(':')[1]));

            textmanager.CharaFace_Img.color = new Color32(255, 255, 255, 255);
        }
        else
        {
            textmanager.DescText.text = textData;

            textmanager.CharaFace_Img.color = new Color32(255, 255, 255, 0);
        }

        textmanager.isText = true;
        talkindex++;

        textmanager.TalkCon();
    }
}

