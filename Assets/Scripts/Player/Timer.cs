using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    // end game timer
    public static float actualTime = 0f;
    public static float initialTime = 0f;

    // in game timer
    public static float fixedActualTimer;
    public TextMeshProUGUI timer;

    void Start()
    {
        fixedActualTimer = 15f;
        actualTime = initialTime;  
    }

    void Update()
    {
        actualTime += 1 * Time.deltaTime;
        fixedActualTimer -=1 * Time.deltaTime;
        timer.text = fixedActualTimer.ToString("F2"); 
        if (actualTime >= 15) 
        {
            actualTime = 15;
        }
        if (fixedActualTimer < 0)
        {
            fixedActualTimer = 0;
        }
    }
}
