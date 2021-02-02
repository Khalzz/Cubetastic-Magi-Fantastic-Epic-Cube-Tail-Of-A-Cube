using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelMenu : MonoBehaviour
{
    public static string level;

    public static void Level1()
    {
        level = ("Level 1");
        Debug.Log(level);
        SceneManager.LoadScene(level);
    }

    public static void Level2()
    {
        level = ("Level 2");
        Debug.Log(level);
        SceneManager.LoadScene(level);
    }

    public static void Level3()
    {
        level = ("Level 3");
        Debug.Log(level);
        SceneManager.LoadScene(level);
    } 

    public static void LevelSandBox()
    {
        level = "Level SandBox";
        Debug.Log(level);
        SceneManager.LoadScene(level);
    }
}