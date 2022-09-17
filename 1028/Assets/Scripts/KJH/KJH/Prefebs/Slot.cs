using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IPointerClickHandler
{
    public int slotNum;
    public Item item;                   //���Կ� ����� �������� ����
    public Image itemIcon;              //�������� ������
    public float clickTime = 0f;
    Inventory inven;

    public ObjectEventTriger E_Trigger;

    public GearLozic gear;


    private void Start()
    {
        E_Trigger = GameObject.Find("Player").GetComponentInChildren<ObjectEventTriger>();
        gear = GameObject.Find("Gear_Plane").GetComponent<GearLozic>();
        inven = Inventory.instance;
    }
    public void UpdateSlotUI()                    //�κ��丮�� �Ƹ����� �ش� ������ ���
    {                                             //
        itemIcon.sprite = item.itemImage;         //�������̹����� ���������� ����
        itemIcon.gameObject.SetActive(true);      //������ Ȱ��ȭ
    }
    public void RemoveSlot()                             //���� ����
    {
        item = null;                                     //�������� ����
        itemIcon.gameObject.SetActive(false);            //�������� ��Ȱ��ȭ
    }

    ItemType OnButtonDoubleClick()                              //����Ŭ�� ->�ش������ ���
    {
        Debug.Log("����Ŭ��");
        return item.itemType;

    }

    void OnButtonClick()                                   //Ŭ�� ->�ش������ ���
    {
        Debug.Log("Ŭ��");
        clickTime = Time.time;

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        
        if (inven.items.Count > slotNum)
        {
            
            if (Mathf.Abs(Time.time - clickTime) < 0.3f)    //����Ŭ�� ->�ش������ ���
            {
                if (OnButtonDoubleClick() != ItemType.ErrorType)
                {
                    Debug.Log("Del");
                    switch (item.itemType)
                    {
                        case ItemType.Object_Gear:
                            if (gear.on_triger)
                            {
                                gear.gearObj.SetActive(true);
                                item.SendItem();                        //������ ���� �ѱ�� ������ Item
                                RemoveSlot();
                                Inventory.instance.RemoveItem(slotNum);
                                clickTime = -1;
                            }
                            //��Ϲ��� ������ ���ൿ
                            
                            break;
                    }
                    
                    
                }
                #region by Triglavian
                /*
                //Debug.Log($"{OnButtonDoubleClick() != ItemType.ErrorType}, {E_Trigger.IsValidPuzzle()}, { E_Trigger.IsSameType(item.itemType)}");
                if (OnButtonDoubleClick() != ItemType.ErrorType)// && E_Trigger.IsValidPuzzle() && E_Trigger.IsSameType(item.itemType)
                {
                    //E_Trigger.ActiveKeyObject();
                    //item.SendItem();                        //������ ���� �ѱ�� ������ Item
                    RemoveSlot();
                    Inventory.instance.RemoveItem(slotNum);
                    //E_Trigger.currentKeyObject = null;
                    clickTime = -1;
                }
                */
                #endregion
            }
            else                                            //Ŭ�� ->�ش������ ���
            {
                OnButtonClick();
            }
        }

    }

}
