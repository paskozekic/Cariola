using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private TextMeshProUGUI text;
    private float time = 0.0f;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        time += Time.deltaTime;
        text.text = (Mathf.Round(time / 60)).ToString() + ":" + (time % 60).ToString("00.00");
    }
}
