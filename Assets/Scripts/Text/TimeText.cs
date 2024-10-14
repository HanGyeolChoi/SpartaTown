using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeText : MonoBehaviour
{
    private Text timeText;
    private void Awake()
    {
        timeText = GetComponent<Text>();
    }

    void Update()
    {
        timeText.text = GetCurrentTime();
    }

    private string GetCurrentTime()
    {
        return DateTime.Now.ToString(("HH : mm"));
    }
}
