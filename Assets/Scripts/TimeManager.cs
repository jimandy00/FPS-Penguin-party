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

    // 제한시간
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
            // 시간이 지나면서 제한시간 -1초씩 감소
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
