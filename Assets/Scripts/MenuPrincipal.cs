using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject painelMenuInicial;
    public void CarregarCenaJogo()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void ScoreBoard()
    {  

        SceneManager.LoadSceneAsync(2);
    }
    public void Sair()
    {
        Application.Quit();
    }

    public void CarregarMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

}