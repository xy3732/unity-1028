using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextManager : MonoBehaviour
{
    public GameObject TextPanel;
    public TextMeshProUGUI DescText;

    [Space(20)]
    public Image CharaFace_Img;

    [HideInInspector]
    public bool isText = false;

    [SerializeField]
    public Dictionary<int, string[]> textData;
    [SerializeField]
    private Dictionary<int, Sprite> portraitData;

    public Sprite[] portraitArr;

    private void Awake()
    {
        textData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();

        GenerateData();

        TextPanel.SetActive(isText);
    }

    // : �ڿ� ���ڴ� ǥ��
    // �⺻ = 0 / ���� = 1 / ��Ǫ�� = 2 / ��� = 3
    void GenerateData()
    {

        #region ��� �� ���� ���

        //Ʋ�� ������ ���/�ùٸ��� ���� ���� Ǯ��
        textData.Add(1, new string[] { "�̷��� �ϴ°� �ƴѰ� ����:2" });
        //���� Ǯ �� ���� ������ Ǯ���� �� ��
        textData.Add(2, new string[] { "������ �ٸ��ź��� �ذ��ϰ� ����:0" });
        //�̹� Ǭ ����� ��ȣ�ۿ� �Ϸ��� �� ��
        textData.Add(3, new string[] { "�ű⿡�� �� �̻� ������ ���°� ����:0" });
        //�ֿ� �� �ִ� �����۰� Q�� ��ȣ�ۿ� �� �� 
        textData.Add(4, new string[] { "�� ���濡 �� �� �ִ� ������ ����. �־�ѱ�?:0" });
        //�ð��� 15�� ������ ��
        textData.Add(5, new string[] { "�����Ͻ� �ð����� ���� �ð����� 15�� ���� ���� �� ����:0" });
        //�ð��� 10�� ������ ��
        textData.Add(6, new string[] { "���� ���ѷ��� �� �� ���� 10�� ���Ҿ�.:2" });
        //�ð��� 5�� ������ ��
        textData.Add(7, new string[] { "���� 5�� �ڸ� �����̾�!:3" });
        #endregion

        #region �Ŵ� ��Ϲ���
        //���� �ر���
        textData.Add(100, new string[] { "��û ũ��!:3", "�׷��� �� �۵��� ������?:2", "�Ƹ��� �̰� �ð��� ��߳� ���� �� �ϳ��� �� ����.:0" });

        //���� �ذ�
        //���� ��Ϲ��� ������ ���
        textData.Add(101, new string[] { "���� ��Ϲ����� �����־�����!:1", "�� ��Ϲ����� ��������.:3", "�׷��� ���� �۵��� ���ϳ�.. ���� ���ϱ�?:2", " �� ��Ϲ����� �¹����� �ʰ� �־� ���� �������� �� �� ����.:3" });
        #endregion

        #region ��Ϲ��� ������
        //���� Ȱ��ȭ ��
        textData.Add(110, new string[] { "��Ϲ����� ���õ� ��� ������... :0", "������ �ƹ��� ������ �Ͼ�� �ʾ�.:0" });
        //�Ŵ� ��� �ذ� ��
        textData.Add(111, new string[] { "�� ���� ��� �۵��ϴ°ɱ�?:0", "���� ���� �������� �������� ��Ϲ����� ���� ���ư����Ѵٰ� ����µ��� :0 ", "�̰ɷ� ���� �� ��������? :0" });
        //�ùٸ� ������� Ǯ��
        textData.Add(112, new string[] { "�ƾ�! ���� �������� ���ư�����?:1" });
        #endregion

        #region ������
        //���� Ȱ��ȭ ��
        textData.Add(120, new string[] { "�������̾�..:0" });
        //��Ϲ��� ������ �ذ� ��
        textData.Add(121, new string[] { "�������� �� �� �ȵ��ư��°ž�..?:2" });
        //1�� �ذ� - �� ���� ���
        textData.Add(122, new string[] { "�� ���ᰡ �����߱���:1", "����̻��� ���Ⱑ ������ݾ�. ���� �����غ���! �� ���ľ��� �� ����. :3" });
        //2�� �ذ� - �����ڽ� ���
        textData.Add(123, new string[] { "�����̴� �̻��� ���Ⱑ ������ ����.:1", "������ �̷� �Ҽ��� ������ �¾�� ���� �ð��� �޶����� ������ �ʾ�. ���� ���� �� ���캸��.:0" });

        #endregion

        #region �ؽð�
        //���� Ȱ��ȭ ��
        textData.Add(130, new string[] { "�ؽð��.:0", "�Ϲ� �ؽð�ʹ� �޸� �����ΰ� ���� ���� �ؽð��� �ҷ�.:0" });
        //���� ���� �ذ� ��
        textData.Add(131, new string[] { "�ؽð��� ���� ������. :0", "�� ������ �ϳ� �����ִ°� ����.. :0" });
        //���� �ذ�  
        //�� ���� ���
        textData.Add(132, new string[] { "����� ������ �� ����.:1" });
        #endregion

        #region �� ������
        //���� Ȱ��ȭ ��  
        textData.Add(140, new string[] { "���� �����ϴ� ������. ���� �� �������� �ҷ�.:0" });
        //���� ���� �ذ� ��
        textData.Add(141, new string[] { "�̰� ��� �Ѿ� �ϴ��� ����� ���� �ʴ°�..:2" });
        //���� �ذ�  
        //�ùٸ� ������� Ǯ��
        textData.Add(142, new string[] { "�ذ��ߴ�! :1" });
        #endregion

        #region ��
        //1�� ���� �ذ� ��
        textData.Add(150, new string[] { "���� ������ �ʾ�..:2", "������ ž�� ��� ������ �ذ��ؾ� �ϴϱ� �� �ذ��ϰ� �����غ���.:0" });
        //��� ���� �ذ� ��
        textData.Add(151, new string[] { "���� ���Ⱦ�!:3", "2������ �ö���. :0" });
        #endregion

        #region 2�� å�� 
        //Ȱ��ȭ ��
        textData.Add(160, new string[] { "å�忡 å�� �� �� �����־�.. :0", "�����ؾ����� ������? :2" });
        //�ذ� - å ������ 3�� �� ���� ��ġ���� ���
        textData.Add(161, new string[] { "����ϰ� �����Ǿ��°� :1" });
        #endregion

        #region õ���
        //������
        textData.Add(170, new string[] { "õ����̾�. �տ� Į�� ����ֳ� :0" });
        //���� �ذ��� - ������, �Ķ���, �ʷϻ�, �����
        textData.Add(171, new string[] { "���� �Ҹ��� ����? ��𼱰� ����� �Ҹ� ������:3" });
        #endregion

        #region ����ž
        //Ȱ��ȭ ��
        textData.Add(180, new string[] { "���� ������ ���� �޷��ִ� ����ž�̾�. ������ �Ű澲�� �ʾƵ� ������ �� ����.:0" });
        // å�� ���� �ذ� ��
        textData.Add(181, new string[] { "�� ����ž�� �����ؼ� ��Ʈ���� �߷��� �ٲ����.:0" });
        //�ذ�
        textData.Add(182, new string[] { "�߷��� ����ȭ �Ǿ���. :1" });
        #endregion

        #region �Ŵ� �� ����
        //���� ��
        textData.Add(190, new string[] { "���� ������ �ʾҾ�..:0", "�̰� �������� �ð�ž�� ������ ��ġ�� �ǵ�.. :2", "�༺ ������ �°� ����� �� �� ����! :0" });
        //������ ��� - �Ŵ� ������
        textData.Add(191, new string[] { "���� ������!:1" });
        #endregion

        #region õü �ð�
        textData.Add(200, new string[] { "��� ��û ũ��!:3", "�̰� �����Ͻ��� ��Ʈ���� �����̱���:0", "�� ���ľ߰ھ�:0" });
        #endregion

        #region 3�� ���� ���� ��
        textData.Add(210, new string[] { "��������!:3", "���� �����Ͻ��� ����ȭ �ɰž�!:1" });
        #endregion

        textData.Add(1000, new string[] { "ID-1000  TEXT test:0", "1:0", "2:0", "3:0", "4:0", "5:0", "Nice, its not have bug:1" });
        portraitData.Add(0, portraitArr[0]);
        portraitData.Add(1, portraitArr[1]);
        portraitData.Add(2, portraitArr[2]);
        portraitData.Add(3, portraitArr[3]);
    }

    public string GetTalk(int id, int talkINdex)
    {
        if (talkINdex == textData[id].Length) return null;
        else return textData[id][talkINdex];
    }

    public Sprite GetPortrait(int id, int portraitIndex)
    {
        return portraitData[portraitIndex];
    }

    public void TalkCon()
    {
        TextPanel.SetActive(isText);
    }
}
