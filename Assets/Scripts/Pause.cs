using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Pause : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject scoreboardPanel;
    private bool scoreboardWasActive;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    private void TogglePause()
    {
        if (pauseMenu.activeSelf)
        {
            ResumeGame();
        }
        else
        {
            scoreboardWasActive = scoreboardPanel.activeSelf;
            pauseMenu.SetActive(true);
            scoreboardPanel.SetActive(false); 
            Time.timeScale = 0; 
        }
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        if (scoreboardWasActive)
        {
            scoreboardPanel.SetActive(true);
        }
        Time.timeScale = 1; 
    }

    public void RestartGame()
    {
        ResumeGame(); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        
        ResumeGame();
    }
}
