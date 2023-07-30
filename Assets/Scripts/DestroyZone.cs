using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{

    // 적이 감지되면 삭제하고 점수를 올려라
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CutePenguin"))
        {

            ParticleManager.instance.particleState = true;
            ParticleManager.instance.particleSystem.transform.position = other.transform.position;
            ParticleManager.instance.

            Destroy(other.gameObject);
            GameManager.Instance.OpenGameOverUI();
            MusicManager.instance.DiePenguin();
            Debug.Log("플레이어의 사망으로 게임이 종료되었습니다.");
        }

        else
        {
            Destroy(other.gameObject);
            Debug.Log("에너미가 감지되었습니다.");
        }

        // local에 저장
        GameObject scoreManagerObject = GameObject.Find("ScoreManager");
        ScoreManager sm = scoreManagerObject.GetComponent<ScoreManager>();
        sm.SetScore(sm.GetScore() + 1);
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
