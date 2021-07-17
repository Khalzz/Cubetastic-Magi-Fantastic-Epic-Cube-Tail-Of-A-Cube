using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    public static bool itsPaused = false;
    public GameObject pauseMenuUi;
    public GameObject firstPauseButton;

    void Update()
    {
        if(Input.GetButtonDown("Pause") && (WinDeathMenu.youWin == false)) //pause
        { 
            if(WinDeathMenu.itsDead == false)
            {
                if(itsPaused == true)
                {
                    Resume();
                }
                else
                {  
                    Pause();
                }
            }
        }     
    }

    public void Resume()
    {
        pauseMenuUi.SetActive(false);
        itsPaused = false;
        Time.timeScale = 1f;     
    }

    public void Pause()
    {
        itsPaused = true;
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        itsPaused = false;
        SceneManager.LoadScene(LevelMenu.level);       
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f;
        itsPaused = false;
        SceneManager.LoadScene("MainMenu");
    }
}
