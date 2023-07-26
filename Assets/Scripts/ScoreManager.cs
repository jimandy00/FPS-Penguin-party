using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // ���� ���� UI
    public Text currentScoreUI;

    // ���� ����
    private int currentScore;

    // �ְ� ���� UI
    public Text bestScoreUI;

    // �ְ� ����
    private int bestScore;

    // currentScore�� ���� �ְ� ȭ�鿡 ǥ���ϱ�
    public void SetScore(int value)
    {
        currentScore++;

        Debug.Log("���� ���� : " + currentScore);
        currentScoreUI.text = "���� ���� : " + currentScore;

        // ���� �������� > �ְ��������?
        if (currentScore > bestScore)
        {
            bestScore = currentScore;

            bestScoreUI.text = "�ְ� ���� : " + bestScore;

            // �ְ����� ����
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

        bestScoreUI.text = "�ְ� ���� : " + bestScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
