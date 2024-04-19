using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackManager : MonoBehaviour
{
    public GameObject scoreboardPanel;

    void Start()
    {
        // Verifica se a flag está definida no PlayerPrefs
        if (PlayerPrefs.HasKey("ShowScoreboard"))
        {
            // Ativa o painel "Scoreboard"
            scoreboardPanel.SetActive(true);

            // Remove a flag do PlayerPrefs para não exibir novamente na próxima vez que a cena for carregada
            PlayerPrefs.DeleteKey("ShowScoreboard");
        }
    }
}