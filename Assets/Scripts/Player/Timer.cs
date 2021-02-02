using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public static float actualTime = 0f;
    public static float initialTime = 0f;
    public TextMeshProUGUI timer;

    void Start()
    {
        actualTime = initialTime;  
    }

    void Update()
    {
        actualTime += 1 * Time.deltaTime;
        timer.text = actualTime.ToString("F2");
        if (actualTime >= 15) 
        {
            actualTime = 15;
        }
    }
}
