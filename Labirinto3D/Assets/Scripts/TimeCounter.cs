using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCounter
{
    private float seconds;
    private float minuts;
    private float hours;

    public void AddTime(float time)
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

    public string GetTime()
    {        
        return string.Format("{0}:{1}:{2}", hours.ToString("0"), minuts.ToString("0"), seconds.ToString("0"));
    }
}
