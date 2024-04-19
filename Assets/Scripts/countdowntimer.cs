using System;
using System.Collections;
using UnityEngine;
using TMPro;
using static CarController;

public class CountdownTimer : MonoBehaviour
{
    public int countdownTime = 3;
    public TextMeshProUGUI countdownDisplay;
    public Rigidbody RB;
    public bool canMove = false;
    public static event Action OnCountdownFinished;
    private void Start()
    {
        ResetTimer();
    }
    public void ResetTimer()
    {
        StopAllCoroutines();  
        countdownTime = 3;    
        canMove = false;      
        countdownDisplay.gameObject.SetActive(true);
        countdownDisplay.text = countdownTime.ToString();
        StartCoroutine(CountdownToStart());  
    }
    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
        countdownDisplay.text = "GO!";
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
        canMove = true;
        OnCountdownFinished?.Invoke();
    }
}
