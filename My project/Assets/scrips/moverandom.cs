using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverandom : MonoBehaviour
{

    public float moveSpeed = 0.2f; // 移动速度

    // Update is called once per frame
    void Update()
    {
        // 生成随机的移动方向
        Vector3 randomDirection = new Vector3(Random.Range(-2f, 2f), Random.Range(-2f, 2f), 0f);
        randomDirection.Normalize(); // 归一化向量长度为1

        // 根据移动速度和时间更新物体的位置
        transform.position += randomDirection * moveSpeed * Time.deltaTime;
    }
}

