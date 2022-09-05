using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ObjectEventTriger : MonoBehaviour
{
    public GameObject TrigerAbleUI;

    public void Start()
    {
        TrigerAbleUI.SetActive(false);
    }

    public void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("EventTriger"))
        {
            TrigerAbleUI.SetActive(true);

            TrigerAbleUI.transform.position = Camera.main.WorldToScreenPoint(other.transform.position + new Vector3(0,0.9f,0));
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("EventTriger"))
        {
            TrigerAbleUI.SetActive(false);
        }
    }
}

