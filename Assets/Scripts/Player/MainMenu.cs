using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public static bool sss;
    public GameObject activate;
    public GameObject deactivate;

    void Update() 
    {
        Confirm();    
    }

    public void Activate()
    {
        sss = true;
        Debug.Log(sss);
    }

    public void Deactivate()
    {
        sss = false;
        Debug.Log(sss);
    }

    public void Confirm()
    {
        if (sss)
        {
            // dejar boton en "deactivate"
            activate.SetActive(false);
            deactivate.SetActive(true);
        }
        else
        {
            // dejar boton en "activate"
            deactivate.SetActive(false);
            activate.SetActive(true);
        }
    }

    public void QuitGame()
    {
        Debug.Log("Quit!!!");
        Application.Quit();
    }
}
