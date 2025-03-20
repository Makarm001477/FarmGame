using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSpecificScene : MonoBehaviour
{
    // ใส่ชื่อฉากที่ต้องการโหลดใน Inspector
    public string sceneToLoad;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LoadScene();
        }
    }

    void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneToLoad))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            Debug.LogWarning("ยังไม่ได้ตั้งค่าชื่อฉาก! โปรดกำหนดค่า sceneToLoad ใน Inspector");
        }
    }
}

