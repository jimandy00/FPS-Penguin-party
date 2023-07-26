using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // 현재 점수 UI
    public Text currentScoreUI;

    // 현재 점수
    private int currentScore;

    // 최고 점수 UI
    public Text bestScoreUI;

    // 최고 점수
    private int bestScore;

    // currentScore에 값을 넣고 화면에 표시하기
    public void SetScore(int value)
    {
        currentScore++;

        Debug.Log("현재 점수 : " + currentScore);
        currentScoreUI.text = "현재 점수 : " + currentScore;

        // 만약 현재점수 > 최고점수라면?
        if (currentScore > bestScore)
        {
            bestScore = currentScore;

            bestScoreUI.text = "최고 점수 : " + bestScore;

            // 최고점수 저장
            PlayerPrefs.SetInt("Best Score", bestScore);
        }
    }
    
    public int GetScore()
    {
        return currentScore;
    }

    // Start is called before the first frame update
    void Start()
    {
        bestScore = PlayerPrefs.GetInt("Best Score", 0);

        bestScoreUI.text = "최고 점수 : " + bestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
