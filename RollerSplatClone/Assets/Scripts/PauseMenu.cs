using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject menuButton;

    public void Pause()
    {
        if (GameIsPaused)
        {
           Resume();
        }
        else
        {
            menuButton.SetActive(false);
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
    }

    public void Resume()
    {
        menuButton.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
}
