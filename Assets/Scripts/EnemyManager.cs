using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    // 현재 시간
    float currentTime;

    // 생성 시간
    float createTime;

    // 최소시간
    public float minTime = 1;

    // 최대시간
    public float maxTime = 5;

    // 적 공장
    public GameObject enemyFactory;

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
            // 3. 적 공장에서 적을 생성하고
            GameObject enemy = Instantiate(enemyFactory);

            // 4. 그것을 내 위치(enemy manager)에 두고싶다.
            enemy.transform.position = transform.position;

            createTime = UnityEngine.Random.Range(minTime, maxTime);

            currentTime = 0;
        }


    }
}
