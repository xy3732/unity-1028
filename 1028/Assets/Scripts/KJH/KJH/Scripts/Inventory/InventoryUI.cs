using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    Inventory inven;                                               //
    public GameObject inventoryPanel;                              //
    public bool isInventory;                              //�κ��丮 Ȱ��ȭ/��Ȱ��ȭ �����ϴ� ����

    public Slot[] slots;                                           //���� �迭
    public Transform slotHolder;

    private void Start()
    {
        isInventory = true;
        inven = Inventory.instance;
        slots = slotHolder.GetComponentsInChildren<Slot>();
        inven.onSlotCountChange = SlotChange;                  //���� ���� �ΰ��ӿ��� ��ȭ�ʿ��ϸ� ���
        inven.onChageItem += RedrawSlotUI;                        //���� �׸���
        inventoryPanel.SetActive(isInventory);                    //���� ��Ȱ��ȭ
        for (int i = 0; i < slots.Length; i++)                    //��� ���� �̹��� ����
        {
            slots[i].RemoveSlot();
        }
    }

    private void FixedUpdate()
    {
        RedrawSlotUI();
    }

    private void SlotChange(int val)                                          
    {
        for(int i = 0; i < slots.Length; i++)
        {
            slots[i].slotNum = i;
            if (i < inven.SlotCnt)
            {
                slots[i].GetComponent<Button>().interactable = true;
            }
            else
            {
                slots[i].GetComponent<Button>().interactable = false;
            }
        }
    }

    /*void Update()
    {

        if (Input.GetKeyDown(KeyCode.Tab))                           //��Ű ������ �κ��丮 ���� �ݱ�
        {
            isInventory = !isInventory;
            inventoryPanel.SetActive(isInventory);
        }
        
    }*/

    void RedrawSlotUI()                                              //�κ��丮 UI �׸���
    {
        for(int i = 0; i < slots.Length; i++)
        {
            slots[i].RemoveSlot();                                   //��� ���� �����
        }
        for(int i = 0; i < inven.items.Count; i++)
        {
            slots[i].item = inven.items[i];                          //�κ��� �������� �����ͼ� ���Կ� ����
            slots[i].UpdateSlotUI();                                 //�׾������� ��������Ʈ�� ���� �̹����� ����
        }
    }

}
