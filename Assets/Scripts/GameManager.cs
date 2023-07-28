using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// game manager
// player가 destroyzone에 닿으면 게임 끝
// ||
// time이 00:00이 되면 게임 끝
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
        Debug.Log("게임을 종료합니다.");
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
