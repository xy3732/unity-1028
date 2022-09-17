using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldItem : MonoBehaviour
{
    public Item item;                            //�������� ���� �ޱ�
    public MeshRenderer mesh;                    //�������� 3D�Ž�
    public Sprite image;                         //�������� ��������Ʈ

    public void SetItem(Item _item)              //������ �⺻ ����
    {
        item.itemName = _item.itemName;          //�������̸�
        item.itemMaterial = _item.itemMaterial;   //���׸���
        item.itemType = _item.itemType;           //������ Ÿ��
        item.itemImage = _item.itemImage;         //���Կ� ����� �̹���
                                                  //
        mesh.material = item.itemMaterial;        //
        image = item.itemImage;                   //
    }

    public Item GetItem()                         //�ܺο��� ������ �����޴� �޼ҵ�
    {
        return item;
    }
    public void DestroyItem()                    //������ ����� ����ϴ� �޼���
    {
        Destroy(gameObject);
    }
}
