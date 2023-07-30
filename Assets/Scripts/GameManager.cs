using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// game manager
// player�� destroyzone�� ������ ���� ��
// ||
// time�� 00:00�� �Ǹ� ���� ��

// ���� ���� ���
public enum GameState
{
    Ready,
    Restart,
    Pause,
    Quit
}
public class GameManager : MonoBehaviour
{

    // �ν��Ͻ�
    public static GameManager Instance = null;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    // ���� ���� ���� ����
    public GameState gState;

    // game over UI
    public GameObject gameOverUI;

    // game start UI
    public GameObject gameStartUI;

    
    // ���� ����
    public void OpenGameOverUI()
    {
        // ���ӿ��� â Ȱ��ȭ
        gameOverUI.SetActive(true);

        // ���� �ӵ� 0���
        Time.timeScale = 0f;

        // ���� ���� = '����'
        gState = GameState.Pause;

        MusicManager.instance.audio.volume = 0.5f;
    }

    // ó������ �ٽ� �ϱ�
    public void RestartGame()
    {
        // ���� �ӵ� 1������� ����
        Time.timeScale = 1f;

        // ó������ ����
        SceneManager.LoadScene(0);

        if (gameStartUI == true)
        {
            gameStartUI.SetActive(false);
        }

        // ���� ���� = '����'
        gState = GameState.Restart;

        MusicManager.instance.PlayMusic();
    }


    // ���� ����
    public void QuitGame()
    {
        // ���� ����
        Application.Quit();

        // ���� ���� = '����'
        gState = GameState.Quit;

        MusicManager.instance.StopMusic();
    }

    // Start is called before the first frame update
    void Start()
    {
        // ���� ���۽� ���ӿ��� �г� ����
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
