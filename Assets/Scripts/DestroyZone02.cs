using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone02 : MonoBehaviour
{

    // �÷��̾ ���̸� ���� ����
    // ���ʹ̰� ���̸� ���ھ�+1�ϰ� ���ʹ� ����
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Equals("Player"))
        {
            Debug.Log("�÷��̾ �׾����ϴ�.");
        }

        Destroy(other.gameObject);
        Debug.Log("���ʹ̸� �����߽��ϴ�.");
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
