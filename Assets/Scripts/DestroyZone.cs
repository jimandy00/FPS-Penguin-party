using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{

    // 적이 감지되면 삭제하고 점수를 올려라
    private void OnTriggerEnter(Collider other)
    {
        // 만약 플레이어라면 게임 종료
        if (other.gameObject.name == "Player")
        {
            // 이거 왜 안되지?
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
