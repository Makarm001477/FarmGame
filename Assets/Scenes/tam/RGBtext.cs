using System.Collections;
using UnityEngine;
using TMPro;

public class RGBText : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro; // Reference to your TextMeshProUGUI component
    public float colorChangeSpeed = 1f; // Speed of the color change

    private void Start()
    {
        if (textMeshPro == null)
        {
            textMeshPro = GetComponent<TextMeshProUGUI>();
        }
        StartCoroutine(ChangeTextColor());
    }

    private IEnumerator ChangeTextColor()
    {
        while (true)
        {
            float r = Mathf.Sin(Time.time * colorChangeSpeed) * 0.5f + 0.5f;
            float g = Mathf.Sin(Time.time * colorChangeSpeed + Mathf.PI / 2) * 0.5f + 0.5f;
            float b = Mathf.Sin(Time.time * colorChangeSpeed + Mathf.PI) * 0.5f + 0.5f;

            textMeshPro.color = new Color(r, g, b);
            yield return null;
        }
    }
}
