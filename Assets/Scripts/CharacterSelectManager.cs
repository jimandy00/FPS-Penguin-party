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

    // ĳ���� ����


    // �ν��Ͻ� ����
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

        // ���� ��ȯ�Ǿ ������Ʈ �ı����� �ʱ�
        DontDestroyOnLoad(gameObject);
    }

    // ���� â���� ������ ĳ���͸� ���� ������ ���
    public Character currentCharacter;

}
