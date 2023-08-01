using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CutePenguin"))
        {
            ParticleManager.instance.particleState = true;
            ParticleManager.instance.particleSystem.transform.position = other.transform.position;
            ParticleManager.instance.StartParticle();

            Destroy(other.gameObject);
            GameManager.Instance.OpenGameOverUI();
            MusicManager.instance.DiePenguin();
            Debug.Log("플레이어의 사망으로 게임이 종료되었습니다.");
        }

        else
        {
            ParticleManager.instance.particleState = true;
            ParticleManager.instance.particleSystem.transform.position = other.transform.position;
            ParticleManager.instance.StartParticle();
            Destroy(other.gameObject);
            Debug.Log("에너미가 감지되었습니다.");
        }

        // local에 저장
        GameObject scoreManagerObject = GameObject.Find("ScoreManager");
        ScoreManager sm = scoreManagerObject.GetComponent<ScoreManager>();
        if(other.gameObject.tag != "CutePenguin")
        {
            sm.SetScore(sm.GetScore() + 1);
        }

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
