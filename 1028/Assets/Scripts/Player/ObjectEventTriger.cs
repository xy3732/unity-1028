using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ObjectEventTriger : MonoBehaviour
{
    public GameObject TrigerAbleUI;

    GameManager gameManager;
    EvenetSelection eventSelection;

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void Start()
    {
        TrigerAbleUI.SetActive(false);
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("EventTriger"))
        {
            //Ʈ���� UI�� ���ӿ�����Ʈ ���� ǥ�� && ���� ���� ��ȣ�ۿ� ������Ʈ�� ������ Ȱ��ȭ
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
            //Ʈ���� UI  ���� ���� ������ ��Ȱ��ȭ
            #region TrigrUI
            TrigerAbleUI.SetActive(false);
            #endregion
        }
    }

    void ClickTriger(Collider other)
    {
        //���������̶�� ��ȯ.
        if (gameManager.isDelayOn == true) return;

        //���� �浹�� ������Ʈ�� �̺�Ʈ Ÿ���� �����ɴϴ�.
        eventSelection = other.gameObject.GetComponent<EvenetSelection>();

        //������ Ŭ���ϴ°� ���� ���ؼ� ������ �ֱ� [1.5��]
       StartCoroutine(gameManager.DelayTimer(1.5f));

        Debug.Log("check");
    }
}

