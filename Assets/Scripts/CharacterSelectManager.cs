using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    Penguin,
    Rabbit
}

public class CharacterSelectManager : MonoBehaviour
{

    // 캐릭터 정의


    // 인스턴스 생성
    public static CharacterSelectManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else if(Instance != null)
        {
            return;
        }

        // 씬이 전환되어도 오브젝트 파괴하지 않기
        DontDestroyOnLoad(gameObject);
    }

    // 선택 창에서 선택한 캐릭터를 다음 씬에서 사용
    public Character currentCharacter;

}
