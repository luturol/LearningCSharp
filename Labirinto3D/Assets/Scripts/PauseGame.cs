using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private Text buttonText;

    private ItemManager itemManager;
    private EndGame endGame;
    private Player player;
    private bool pauseOrResume = false;

    // Start is called before the first frame update
    void Start()
    {
        endGame = FindObjectOfType<EndGame>();
        itemManager = FindObjectOfType<ItemManager>();
        player = FindObjectOfType<Player>();
    }

    public void PauseOrResumeGame()
    {
        pauseOrResume = !pauseOrResume;

        //true = pause
        //false = resume
        if (!pauseOrResume)
        {
            buttonText.text = "Pause";
        }
        else
        {
            buttonText.text = "Resume";
        }

        endGame.SetStopCounting(pauseOrResume);
        itemManager.SetStopCounting(pauseOrResume);
        player.SetCanMove(!pauseOrResume);
    }

    public void Pause()
    {
        endGame.SetStopCounting(true);
        itemManager.SetStopCounting(true);
        player.SetCanMove(false);
        gameObject.SetActive(false);
    }
}
