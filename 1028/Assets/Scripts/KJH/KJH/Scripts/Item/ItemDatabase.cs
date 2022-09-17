using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public static ItemDatabase instance;
    public int itemCount;
    private void Awake()
    {
        instance = this;
    }
    public List<Item> itemDB = new List<Item>();                                          //������ ���� �����ϴ� ����Ʈ

    public GameObject fieldItemPrefab;                                                    //�ʵ������ ������ ����
    public Vector3[] pos;                                                                 //�ʵ�������� ���� ��ǥ

    private void Start()
    {
        for(int i = 0; i < itemCount; i++)                                                         //�ݺ��� ���ǹ��� �ִ� �������� ���� ����Ƽ�ν����� â�� POS ���� ��ġ�Ұ�
        {
            GameObject go = Instantiate(fieldItemPrefab, pos[i], Quaternion.identity);     //����Ƽ �������� ���� ��ŭ �ν�����â���� ��ǥ �Է� 
            go.GetComponent<FieldItem>().SetItem(itemDB[0]);//Random.Range(0, 3)           //�������� ������ ������ �̸� ������ ����ؼ� ����ϰų� ���� �����ؼ� ��ġ
        }
    }
}
