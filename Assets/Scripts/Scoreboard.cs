using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    public List<TMP_Text> topTimesTexts;
    public GameObject scoreBoardPanel; 

    void Start()
    {
        scoreBoardPanel.SetActive(true);
        
        UpdateScoreboard();
    }

    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void UpdateScoreboard()
    {
        for (int i = 0; i < topTimesTexts.Count && i < 10; i++)
        {
            string timeKey = "Time" + (i + 1);
            
            if (PlayerPrefs.HasKey(timeKey))
            {
                float time = PlayerPrefs.GetFloat(timeKey);
                
                topTimesTexts[i].text = $" {FormatTime(time)}";
            }
            else
            {
                topTimesTexts[i].text = $" --:--";
            }
        }
    }
}
