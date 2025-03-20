using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // ความเร็วในการเดิน
    public float rotationSpeed = 200f; // ความเร็วในการหมุน

    void Update()
    {
        // รับค่าปุ่มเดินหน้า-ถอยหลัง (W / S)
        float moveZ = Input.GetAxis("Vertical"); // W (1) / S (-1)

        // รับค่าปุ่มหมุนซ้าย-ขวา (A / D)
        float rotateY = Input.GetAxis("Horizontal"); // A (-1) / D (1)

        // คำนวณการเดินหน้า-ถอยหลัง
        Vector3 move = transform.forward * moveZ * speed * Time.deltaTime;
        transform.position += move; // ขยับตำแหน่งตัวละคร

        // คำนวณการหมุนซ้าย-ขวา
        transform.Rotate(Vector3.up * rotateY * rotationSpeed * Time.deltaTime);
    }
}

