using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Ÿ�̸�
// �ð��� ����Ǹ� ������ ������.

public class TimeManager : MonoBehaviour
{
    // ���� �ð� ǥ��
    public Text timeTextUI;

    // ���ѽð�
    float limitTime = 120f;

    int min, sec;

    // Start is called before the first frame update
    void Start()
    {
        timeTextUI.text =  "02 : 00";
    }

    // Update is called once per frame
    void Update()
    {
        while(limitTime > 0)
        {
            // �ð��� �����鼭 ���ѽð� -1�ʾ� ����
           limitTime -= (int)Time.deltaTime;

            if(limitTime < 60)
            {
                timeTextUI.text = "00 : " + sec;
            }

            min = (int)limitTime / 60;
            sec = (int)limitTime % 60;

            timeTextUI.text = min + " : " + sec;
        }

        timeTextUI.text = "00 : 00";
    }
}
