using System;
using System.Collections;
using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public int countdownTime = 3;
    public TextMeshProUGUI countdownDisplay;
    public bool canMove = false;

    public static event Action OnCountdownFinished;

    private void Start()
    {
        ResetTimer();
    }

    // Make this method public so it can be called from other scripts
    public void ResetTimer()
    {
        StopAllCoroutines();  
        countdownTime = 3;    // Reset the countdown time
        canMove = false;      // Reset movement control
        countdownDisplay.gameObject.SetActive(true);
        countdownDisplay.text = countdownTime.ToString();
        StartCoroutine(CountdownToStart());  // Optionally restart the countdown automatically
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
