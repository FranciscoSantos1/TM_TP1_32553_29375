using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContadorVoltas : MonoBehaviour
{
    public TMP_Text textoVoltas;
    public TMP_Text textoTempo;
    private int voltaAtual = 0;
    private float tempo = 0f;


    private bool passouStart = false;
    private bool passouCheckpoint1 = false;
    private bool passouCheckpoint2 = false;
    private bool passouCheckpoint3 = false;

    private void Start()
    {

        textoVoltas.text = "0 /3";
        textoTempo.text = "00:00";
    }

    private void Update()
    {

        tempo += Time.deltaTime;
        textoTempo.text = FormatTime(tempo);
    }

    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void OnTriggerEnter(Collider other)
    {

        
        if (other.CompareTag("start"))
        {
            if (passouStart && passouCheckpoint1 && passouCheckpoint2 && passouCheckpoint3)
            {
                voltaAtual++;
                textoVoltas.text = voltaAtual + " /3";

                //passouStart = false;
                passouCheckpoint1 = false;
                passouCheckpoint2 = false;
                passouCheckpoint3 = false;
            }
            passouStart = true;
        }
        else if (other.CompareTag("checkpoint1") && passouStart)
        {
            passouCheckpoint1 = true;
        }
        else if (other.CompareTag("checkpoint2") && passouCheckpoint1)
        {
            passouCheckpoint2 = true;
        }
        else if (other.CompareTag("checkpoint3") && passouCheckpoint2)
        {
            passouCheckpoint3 = true;
            
        }
    }

}