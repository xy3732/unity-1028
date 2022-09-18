using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButtonLozic : MonoBehaviour
{
    [SerializeField]
    Material m_leftbutton;
    [SerializeField]
    Material m_rightbutton;

    Color[] rightColor;
    Color[] leftColor;
    private void Awake()
    {
        rightColor = new Color[7];
        leftColor = new Color[7];
        #region 오른쪽 버튼 색상
        rightColor[0].r = 0xF9;  //분홍
        rightColor[0].g = 0x4B;
        rightColor[0].b = 0x8F;

        rightColor[1].r = 0xFF;  //노랑
        rightColor[1].g = 0xFB;
        rightColor[1].b = 0x52;
        
        rightColor[2].r = 0x5E;
        rightColor[2].g = 0xCF;
        rightColor[2].b = 0x95;
        
        rightColor[3].r = 0xF9;
        rightColor[3].g = 0x4B;
        rightColor[3].b = 0x8F;
        
        rightColor[4].r = 0xFE;
        rightColor[4].g = 0xAA;
        rightColor[4].b = 0x42;
        
        rightColor[5].r = 0x26;
        rightColor[5].g = 0x26;
        rightColor[5].b = 0x26;
        
        rightColor[6].r = 0x4B;
        rightColor[6].g = 0xC6;
        rightColor[6].b = 0xE8;
        
        rightColor[7].r = 0x9B;
        rightColor[7].g = 0x4D;
        rightColor[7].b = 0xEC;
        #endregion

        #region 왼쪽 버튼 색상
        leftColor[0].r = 0x4B;
        leftColor[0].g = 0xC6;
        leftColor[0].b = 0xE8;

        leftColor[1].r = 0x42;
        leftColor[1].g = 0x96;
        leftColor[1].b = 0x1F;

        leftColor[2].r = 0x5E;
        leftColor[2].g = 0xCF;
        leftColor[2].b = 0x95;

        leftColor[3].r = 0xF9;
        leftColor[3].g = 0x4B;
        leftColor[3].b = 0x8F;

        leftColor[4].r = 0xFE;
        leftColor[4].g = 0xAA;
        leftColor[4].b = 0x42;

        leftColor[5].r = 0x26;
        leftColor[5].g = 0x26;
        leftColor[5].b = 0x26;

        leftColor[6].r = 0x4B;
        leftColor[6].g = 0xC6;
        leftColor[6].b = 0xE8;

        leftColor[7].r = 0x9B;
        leftColor[7].g = 0x4D;
        leftColor[7].b = 0xEC;
        #endregion
    }

    void Start()
    {
        m_rightbutton.color = rightColor[0];
        m_leftbutton.color = leftColor[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
