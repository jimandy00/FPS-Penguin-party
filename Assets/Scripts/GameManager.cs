using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    GameState gState = new GameState();

    // ���� ���� ���
    public enum GameState
    {
        Ready,
        Run,
        Pause,
        GameOver
    }

    // �ɼ� ȭ���� UI ������Ʈ ����
    public GameObject gameOption;


    // �ɼ� ȭ�� �ѱ�
    public void OpenOptionWindow()
    {
        // �ɼ� â�� ����.
        gameOption.SetActive(true);

        // ���� �ӵ��� 0������� �����Ѵ�(����)
        Time.timeScale = 0f;

        // ���� ���¸� �Ͻ� ������ �����Ѵ�.
        
        gState = GameState.Pause;
    }

    // ����ϱ� �ɼ�
    public void CloseOptionWindow()
    {
        // �ɼ�â�� ��Ȱ��ȭ
        gameOption.SetActive(false);

        // ���� �ӵ��� 1������� ����(���)
        Time.timeScale = 1f;
        // ���� ���¸� ���� �� ���·� �����Ѵ�.
        gState = GameState.Run;
    }

    // �ٽ��ϱ� �ɼ�
    public void RestartGame()
    {
        // ���� �ӵ��� 1������� ����(���)
        Time.timeScale = 1f;

        // ���� �� ��ȣ�� �ٽ� �ε�
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // ���� �����ϱ�
    public void QuitGame()
    {
        // ���ø����̼� ����
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
