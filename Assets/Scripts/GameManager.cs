using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// game manager
// player�� destroyzone�� ������ ���� ��
// ||
// time�� 00:00�� �Ǹ� ���� ��
public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void gameOver()
    {
        Debug.Log("������ �����մϴ�.");
        Application.CancelQuit();

#if !UNITY_EDITOR

        System.Diagnostics.Process.GetCurrentProcess().Kill();

#endif

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
