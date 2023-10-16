using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float moveDistance = 5f;  // �����ƶ��ľ���
    public float moveDuration = 1f;  // �ƶ���ʱ����
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
        float t = Mathf.PingPong(timer / moveDuration, 1f);  // ʹ��PingPong��������һ����0��1֮��ѭ���仯����ֵ
        transform.position = Vector3.Lerp(startPosition, targetPosition, t);
    }
}
