using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyaerMove : MonoBehaviour
{
    // 플레이어 속도
    public float speed = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0 , v);
        dir = dir.normalized;

        // 이동 속도에 맞춰서 이동
        transform.position += dir * speed * Time.deltaTime;
    }
}
