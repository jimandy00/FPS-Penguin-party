using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    public Character character;
    public SelectCharacter[] characters;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (CharacterSelectManager.Instance.currentCharacter == character) Selected();
        else DeSelected();
    }

    // 마우스로 캐릭터 선택하기
    private void OnMouseUpAsButton()
    {
        CharacterSelectManager.Instance.currentCharacter = character;
        Selected();
        for(int i =0; i < characters.Length; i++)
        {
            if (characters[i] != this) characters[i].DeSelected();
        }
    }

    void Selected()
    {
        spriteRenderer.color = new Color(1f, 1f, 1f);
    }

    void DeSelected()
    {
        spriteRenderer.color = new Color(0.5f, 0.5f, 0.5f);

    }
}
