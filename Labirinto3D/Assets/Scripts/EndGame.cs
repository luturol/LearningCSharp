using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    [SerializeField] private GameObject endPanel;
    [SerializeField] private Text timeToFinishText;
    [SerializeField] private Text timeToCollectText;

    private ItemManager itemManager;
    private PauseGame pauseGame;
    private bool hasEnded = false;
    private TimeCounter timeCounter;
    private bool stopCounting = false;

    public void SetStopCounting(bool blockCounter) => stopCounting = blockCounter;

    void Start()
    {
        itemManager = FindObjectOfType<ItemManager>();
        pauseGame = FindObjectOfType<PauseGame>();
        timeCounter = new TimeCounter();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasEnded)
        {
            pauseGame.Pause();            
            endPanel.SetActive(true);
            
            timeToFinishText.text = "Tempo para sair: " + timeCounter.GetTime();
            timeToCollectText.text = "Tempo para coletar: " + itemManager.TimeToCollect;
        }
        else if(!stopCounting)
        {
            timeCounter.AddTime(Time.deltaTime);
        }
    }

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            hasEnded = true;
        }
    }
}
