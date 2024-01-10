using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenu; 
    private bool isPaused = false;

    void Start()
    {
        
        Button pauseButton = GetComponent<Button>();

        
       // pauseButton.onClick.AddListener(() => TogglePause());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0f; 
            ShowPauseMenu();
        }
        else
        {
            Time.timeScale = 1f; 
            HidePauseMenu();
        }
    }

    void ShowPauseMenu()
    {
        
        pauseMenu.SetActive(true);
    }

    void HidePauseMenu()
    {
        
        pauseMenu.SetActive(false);
    }
}
