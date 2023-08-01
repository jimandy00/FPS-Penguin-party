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
            Debug.Log("�÷��̾��� ������� ������ ����Ǿ����ϴ�.");
        }

        else
        {
            ParticleManager.instance.particleState = true;
            ParticleManager.instance.particleSystem.transform.position = other.transform.position;
            ParticleManager.instance.StartParticle();
            Destroy(other.gameObject);
            Debug.Log("���ʹ̰� �����Ǿ����ϴ�.");
        }

        // local�� ����
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
