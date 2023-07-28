using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 타이머
// 시간이 만료되면 게임이 끝난다.

public class TimeManager : MonoBehaviour
{
    // 남은 시간 표시
    public Text timeTextUI;

    // 현재 시간
    float currentTime;

    // 제한시간
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
            Debug.Log("시간 가는중");
        }
        else if (currentTime == 0)
        {
            Stop_Timer();
        }
    }

    private void Stop_Timer()
    {
        timeTextUI.text = "00 : 00";
        Debug.Log("타이머 멈춤");
    }

    private void Reset_Timer()
    {
        currentTime = limitTime;
        min = (int)currentTime / 60;
        sec = (int)currentTime % 60;
        timeTextUI.text = $"{min} : {sec}";
        Debug.Log("시간 초기화");
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
