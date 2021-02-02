using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using TMPro;

public class WinDeathMenu : MonoBehaviour
{
    //death
    public Transform deathPosition;
    public static bool itsDead;
    public LayerMask whatIsDeath;
    public float footDeathRadio;

    //win
    public LayerMask whatIsWin;
    public static bool youWin; 

    //ui
    public GameObject WinMenuUi;
    public GameObject DeadMenuUi;
    public GameObject timer;
    public TextMeshProUGUI endTime;

    void Update()
    {
        itsDead = Physics2D.OverlapCircle(deathPosition.position,footDeathRadio,whatIsDeath);
        youWin = Physics2D.OverlapCircle(deathPosition.position,footDeathRadio,whatIsWin);

        if(youWin == true)
        {
            timer.SetActive(false);
            Win();
        }
        else if(itsDead == true)
        {
            timer.SetActive(false);
            Death();
        }
        else if(Timer.actualTime == 15)
        {
            timer.SetActive(false);
            Death();
        }
        else if(PauseMenu.itsPaused == true)
        {
            timer.SetActive(false);
            Time.timeScale = 0f;
        }
        else
        {
            timer.SetActive(true);
            Time.timeScale = 1f;
        }
    }

    public void Win()
    {
        WinMenuUi.SetActive(true);
        endTime.text = ("your time was " + Timer.actualTime.ToString("F2") + " seconds");
        Time.timeScale = 0f; //time stops
    }
    
    public void Death()
    {
        DeadMenuUi.SetActive(true);
        Time.timeScale = 0f;
    }

    public void next()
    {
        Time.timeScale = 1f;

        if(LevelMenu.level == "Level 1")
        {
            LevelMenu.Level2();
        }
        else if(LevelMenu.level == "Level 2")
        {
            LevelMenu.Level3();
        }
        else if(LevelMenu.level == "Level 3")
        {
            LevelMenu.LevelSandBox();
        }
        else if(LevelMenu.level == "Level SandBox")
        {
            Debug.Log("Blame me for not delete this");
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(LevelMenu.level);
        Time.timeScale = 1f;
    }
}
