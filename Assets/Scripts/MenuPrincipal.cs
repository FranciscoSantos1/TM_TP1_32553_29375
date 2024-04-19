using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject painelMenuInicial;

    public void CarregarCenaJogo()
    {
        // Carrega a cena do jogo "Track" quando o MenuPrincipal é iniciado
        SceneManager.LoadScene("Track");
    }

    public void ScoreBoard()
    {
        // Define uma flag no PlayerPrefs indicando que o placar deve ser exibido
        PlayerPrefs.SetInt("ShowScoreboard", 1);

        // Carrega a cena do placar de pontuação
        SceneManager.LoadScene("Scoreboard");
    }

    public void Sair()
    {
        // Sai do jogo quando o botão "Sair" é pressionado
        Application.Quit();
    }
}