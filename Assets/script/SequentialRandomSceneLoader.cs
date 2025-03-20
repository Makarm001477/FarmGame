using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SequentialRandomSceneLoader : MonoBehaviour
{
    // รายชื่อฉากที่ต้องการสุ่ม (1-10)
    public List<string> randomScenes = new List<string>();

    // ฉากสุดท้าย (ฉากที่ 11)
    public string finalScene = "Scene11";

    private List<string> remainingScenes;

    private void Start()
    {
        // คัดลอกฉากที่ต้องการสุ่มเก็บไว้
        remainingScenes = new List<string>(randomScenes);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        if (remainingScenes.Count > 0)
        {
            // สุ่มเลือกฉากจากรายการที่เหลือ
            int randomIndex = Random.Range(0, remainingScenes.Count);
            string nextScene = remainingScenes[randomIndex];

            // ลบฉากที่เลือกออกจากรายการ
            remainingScenes.RemoveAt(randomIndex);

            // โหลดฉากที่เลือก
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            // ถ้าสุ่มครบทุกฉากแล้ว ให้ไปฉากสุดท้าย
            SceneManager.LoadScene(finalScene);
        }
    }
}

