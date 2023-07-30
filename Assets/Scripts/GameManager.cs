using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// game manager
// player가 destroyzone에 닿으면 게임 끝
// ||
// time이 00:00이 되면 게임 끝

// 게임 상태 상수
public enum GameState
{
    Ready,
    Restart,
    Pause,
    Quit
}
public class GameManager : MonoBehaviour
{

    // 인스턴스
    public static GameManager Instance = null;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    // 현재 게임 상태 변수
    public GameState gState;

    // game over UI
    public GameObject gameOverUI;

    // game start UI
    public GameObject gameStartUI;

    
    // 게임 오버
    public void OpenGameOverUI()
    {
        // 게임오버 창 활성화
        gameOverUI.SetActive(true);

        // 게임 속도 0배속
        Time.timeScale = 0f;

        // 게임 상태 = '멈춤'
        gState = GameState.Pause;

        MusicManager.instance.audio.volume = 0.5f;
    }

    // 처음부터 다시 하기
    public void RestartGame()
    {
        // 게임 속도 1배속으로 설정
        Time.timeScale = 1f;

        // 처음부터 시작
        SceneManager.LoadScene(0);

        if (gameStartUI == true)
        {
            gameStartUI.SetActive(false);
        }

        // 게임 상태 = '시작'
        gState = GameState.Restart;

        MusicManager.instance.PlayMusic();
    }


    // 게임 종료
    public void QuitGame()
    {
        // 게임 종료
        Application.Quit();

        // 게임 상태 = '종료'
        gState = GameState.Quit;

        MusicManager.instance.StopMusic();
    }

    // Start is called before the first frame update
    void Start()
    {
        // 게임 시작시 게임오버 패널 끄기
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
