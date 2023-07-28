using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    // 현재 시간
    float currentTime;

    // 생성 시간
    float createTime;

    // 최소시간
    public float minTime = 0.5f;

    // 최대시간
    public float maxTime = 3f;

    // 적 공장
    public GameObject enemyFactory;
    public GameObject bigEnemeyFactory;

    // Start is called before the first frame update
    void Start()
    {
        createTime = UnityEngine.Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        // 1. 시간이 흐르다가
        currentTime += Time.deltaTime;

        // 2. 일정 시간이 되면
        if (currentTime > createTime) {

            int bigEnemySpawnPer = UnityEngine.Random.Range(0, 9);

            if (bigEnemySpawnPer < 3) 
            {
                GameObject bigEnemy = Instantiate(bigEnemeyFactory);
                bigEnemy.transform.position = transform.position;
            }
            else
            {
                // 3. 적 공장에서 적을 생성하고
                GameObject enemy = Instantiate(enemyFactory);

                // 4. 그것을 내 위치(enemy manager)에 두고싶다.
                enemy.transform.position = transform.position;
            }
            
            createTime = UnityEngine.Random.Range(minTime, maxTime);

            currentTime = 0;
        }


    }
}
