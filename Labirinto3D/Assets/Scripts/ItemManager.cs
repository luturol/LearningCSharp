using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    private List<Item> items;
    private bool stopCounting = false;
    private TimeCounter timeCounter;

    public string TimeToCollect => timeCounter.GetTime();
    public void SetStopCounting(bool blockCounter) => stopCounting = blockCounter;
    
    void Start()
    {
        items = FindObjectsOfType<Item>().ToList();
        timeCounter = new TimeCounter();
    }

    // Update is called once per frame
    void Update()
    {        
        if(!stopCounting)
        {            
            timeCounter.AddTime(Time.deltaTime);
        }

        if(items.Count(e => e.IsCollected) == items.Count())
        {
            stopCounting = true;
        }
    }
}
