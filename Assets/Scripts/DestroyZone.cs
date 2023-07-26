using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{

    // ���� �����Ǹ� �����ϰ� ������ �÷���
    private void OnTriggerEnter(Collider other)
    {
        // ���� �÷��̾��� ���� ����
        if (other.gameObject.name == "Player")
        {
            // �̰� �� �ȵ���?
            Application.Quit();
        }

        else
        {
            Destroy(other.gameObject);

            GameObject scoreManagerObject = GameObject.Find("ScoreManager");
            ScoreManager sm = scoreManagerObject.GetComponent<ScoreManager>();

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
