using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomTextColor : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro; // ลาก TextMeshPro UI มาใส่ใน Inspector
    private float changeInterval = 2f;

    void Start()
    {
        InvokeRepeating("ChangeColor", 0f, changeInterval);
    }

    void ChangeColor()
    {
        textMeshPro.color = new Color(Random.value, Random.value, Random.value);
    }
}

