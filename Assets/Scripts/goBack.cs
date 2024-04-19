using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class goBack : MonoBehaviour
{
    public GameObject painelMenuInicial;
    public void CarregarCenaJogo()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
