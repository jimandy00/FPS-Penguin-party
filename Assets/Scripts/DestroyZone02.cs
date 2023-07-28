using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone02 : MonoBehaviour
{

    // 플레이어가 닿이면 게임 종료
    // 에너미가 닿이면 스코어+1하고 에너미 삭제
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Equals("Player"))
        {
            Debug.Log("플레이어가 죽었습니다.");
        }

        Destroy(other.gameObject);
        Debug.Log("에너미를 삭제했습니다.");
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
