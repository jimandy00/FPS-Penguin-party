using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{

    // ���� �����Ǹ� �����ϰ� ������ �÷���
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
            Debug.Log("�÷��̾��� ������� ������ ����Ǿ����ϴ�.");
        }

        else
        {
            Destroy(other.gameObject);
            Debug.Log("���ʹ̰� �����Ǿ����ϴ�.");
        }

        // local�� ����
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
