using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
    public float timeRemaining = 0;
    public bool timeIsRunning = false;
    public TMP_Text timeText;

    void OnEnable()
    {
        CountdownTimer.OnCountdownFinished += StartTimer;
    }

    void OnDisable()
    {
        CountdownTimer.OnCountdownFinished -= StartTimer;
    }

    private void StartTimer()
    {
        timeRemaining = 0;  // Reset the timer
        timeIsRunning = true;  // Start the timer
    }

    void Update()
    {
        if (timeIsRunning)
        {
            timeRemaining += Time.deltaTime;
            DisplayTime(timeRemaining);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}