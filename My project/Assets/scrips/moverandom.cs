using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverandom : MonoBehaviour
{

    public float moveSpeed = 0.2f; // �ƶ��ٶ�

    // Update is called once per frame
    void Update()
    {
        // ����������ƶ�����
        Vector3 randomDirection = new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0f);
        randomDirection.Normalize(); // ��һ����������Ϊ1

        // �����ƶ��ٶȺ�ʱ����������λ��
        transform.position += randomDirection * moveSpeed * Time.deltaTime;
    }
}

