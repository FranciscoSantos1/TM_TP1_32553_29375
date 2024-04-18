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
        // Implemente aqui a lógica para exibir o placar de pontuação
    }

    public void Sair()
    {
        // Sai do jogo quando o botão "Sair" é pressionado
        Application.Quit();
    }
}