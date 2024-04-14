using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class timmer : MonoBehaviour
{
    public float timeRemainig=0;
    public bool timeIsRunning =true;
    public TMP_Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        timeIsRunning=true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeRemainig>=0)
        {
            timeRemainig+=Time.deltaTime;
            DisplayTime(timeRemainig);
        }
    }
    void DisplayTime (float timeToDisplay){
        timeToDisplay+=1;
        float minutes=Mathf.FloorToInt(timeToDisplay/60);
        float seconds=Mathf.FloorToInt(timeToDisplay%60);
        timeText.text=string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
