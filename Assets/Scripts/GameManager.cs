using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    GameState gState = new GameState();

    // 게임 상태 상수
    public enum GameState
    {
        Ready,
        Run,
        Pause,
        GameOver
    }

    // 옵션 화면의 UI 오브젝트 변수
    public GameObject gameOption;


    // 옵션 화면 켜기
    public void OpenOptionWindow()
    {
        // 옵션 창을 연다.
        gameOption.SetActive(true);

        // 게임 속도로 0배속으로 설정한다(정지)
        Time.timeScale = 0f;

        // 게임 상태를 일시 정지로 변경한다.
        
        gState = GameState.Pause;
    }

    // 계속하기 옵션
    public void CloseOptionWindow()
    {
        // 옵션창을 비활성화
        gameOption.SetActive(false);

        // 게임 속도를 1배속으로 설정(계속)
        Time.timeScale = 1f;
        // 게임 상태를 게임 중 상태로 변경한다.
        gState = GameState.Run;
    }

    // 다시하기 옵션
    public void RestartGame()
    {
        // 게임 속도를 1배속으로 설정(계속)
        Time.timeScale = 1f;

        // 현재 씬 번호를 다시 로드
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // 게임 종료하기
    public void QuitGame()
    {
        // 어플리케이션 종료
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
