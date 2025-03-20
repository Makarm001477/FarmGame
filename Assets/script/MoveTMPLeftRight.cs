using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoveTMPLeftRight : MonoBehaviour
{
    public TextMeshProUGUI tmpText; // ลาก TMP มาใส่ใน Inspector
    public float speed = 2f; // ความเร็วในการขยับ
    public float distance = 100f; // ระยะทางที่ขยับไปมา

    private Vector3 startPosition;

    void Start()
    {
        startPosition = tmpText.rectTransform.anchoredPosition;
    }

    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, distance * 2) - distance;
        tmpText.rectTransform.anchoredPosition = new Vector3(startPosition.x + movement, startPosition.y, startPosition.z);
    }
}
