using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrackManager : MonoBehaviour
{
    public GameObject scoreboardPanel;
    void Start()
    {
        if (PlayerPrefs.HasKey("ShowScoreboard"))
        {
            scoreboardPanel.SetActive(true);

            PlayerPrefs.DeleteKey("ShowScoreboard");
        }
    }

      public void CarregarMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

}