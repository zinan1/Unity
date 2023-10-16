using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float moveDistance = 5f;  // 上下移动的距离
    public float moveDuration = 1f;  // 移动的时间间隔
    private Vector3 startPosition;
    private Vector3 targetPosition;
    private float timer;

    private void Start()
    {
        startPosition = transform.position;
        targetPosition = startPosition + Vector3.up * moveDistance;
        timer = 0f;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        float t = Mathf.PingPong(timer / moveDuration, 1f);  // 使用PingPong函数生成一个在0到1之间循环变化的数值
        transform.position = Vector3.Lerp(startPosition, targetPosition, t);
    }
}
