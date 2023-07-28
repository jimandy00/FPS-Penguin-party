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

    // ���� �ð�
    float currentTime;

    // ���ѽð�
    float limitTime = 120f;

    int min, sec;

    private void Timer()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            min = (int)currentTime / 60;
            sec = (int)currentTime % 60;
            timeTextUI.text = $"{min} : {sec}";
            Debug.Log("�ð� ������");
        }
        else if (currentTime == 0)
        {
            Stop_Timer();
        }
    }

    private void Stop_Timer()
    {
        timeTextUI.text = "00 : 00";
        Debug.Log("Ÿ�̸� ����");
    }

    private void Reset_Timer()
    {
        currentTime = limitTime;
        min = (int)currentTime / 60;
        sec = (int)currentTime % 60;
        timeTextUI.text = $"{min} : {sec}";
        Debug.Log("�ð� �ʱ�ȭ");
    }



    // Start is called before the first frame update
    void Start()
    {
        Reset_Timer();
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }
}
