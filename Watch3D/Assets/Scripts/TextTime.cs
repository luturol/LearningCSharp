using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTime : MonoBehaviour
{
    [SerializeField] private Text timeText;

    private float seconds;
    private float minuts;
    private float hours;

    private void AddTime(float time)
    {
        seconds += time;

        if (seconds >= 60)
        {
            minuts++;
            seconds = 0;
        }

        if (minuts >= 60)
        {
            hours++;
            minuts = 0;
        }
    }

    private string GetTime()
    {        
        return string.Format("{0}:{1}:{2}", hours.ToString("00"), minuts.ToString("00"), seconds.ToString("00"));
    }

    // Update is called once per frame
    void Update()
    {
        AddTime(Time.deltaTime);
        timeText.text = GetTime();
    }
}
