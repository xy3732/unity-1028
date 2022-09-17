using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType                           //������ Ÿ��
{
    ErrorType = -1,
    Object = 0,
    KeyItem,
    #region by Triglavian
    Object_Gear,                               //��Ϲ���
    Object_Fuel,
    Object_ToolBox,
    Object_StarPiece,
    Object_Book1,
    Object_Book2,
    Object_Book3,
    Object_Sun,
    Object_Mercury,
    Object_Venus,
    Object_Earth,
    Object_Mars,
    Object_Jupiter,
    Object_Saturn,
    Object_Uranus,
    Object_Neptune,
    #endregion                              
    MaxItemType
}


[System.Serializable]
public class Item
{
    public ItemType itemType;                //������ Ÿ��
    public string itemName;                  //������ �̸�
    public Material itemMaterial;            //������ 3D ���׸���
    public Sprite itemImage;                 //���Կ� ���� 2D ��������Ʈ

    public Item SendItem()
    {
        return this;
    }
}
