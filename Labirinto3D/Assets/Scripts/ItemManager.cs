using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private List<Item> items;
    private bool stopCounting = false;
    
    private float seconds;
    private float minuts;
    private float hours;

    public string TimeToCollect => hours.ToString("00") + ":" + minuts.ToString("00") + ":" + seconds.ToString("00");
    void Start()
    {
        items = GetComponents<Item>().ToList();
    }

    // Update is called once per frame
    void Update()
    {        
        if(!stopCounting)
        {
            seconds += Time.time;

            if(seconds == 60)
            {
                minuts++;
                seconds = 0;
            }

            if(minuts == 60)
            {
                hours++;
                minuts = 0;
            }                
        }

        if(items.Count(e => e.IsCollected) == items.Count())
        {
            stopCounting = true;
        }
    }
}
