using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    public bool timerActive = true;
    public float time = 0;
    public TextMeshProUGUI timerText;
    private void FixedUpdate()
    {
        if (!timerActive) return;
        time += Time.deltaTime;
        timerText.text = "Time: " + time.ToString("F2");
    }
}
