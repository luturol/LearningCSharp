using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        NextGuess();
        SetGuessText();
    }

    private void SetGuessText()
    {
        guessText.text = guess.ToString();
    }
    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
        SetGuessText();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
        SetGuessText();
    }

    private void NextGuess()
    {
        guess = Random.Range(min, max + 1);
    }
}
