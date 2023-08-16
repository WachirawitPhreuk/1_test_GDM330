using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int startingLives = 3;
    public Text livesText;
    public GameObject gameOverScreen;

    private int remainingLives;

    private void Start()
    {
        remainingLives = startingLives;
        UpdateLivesUI();
    }

    public void PlayerHit()
    {
        remainingLives--;

        if (remainingLives <= 0)
        {
            GameOver();
        }
        else
        {
            UpdateLivesUI();
        }
    }

    private void UpdateLivesUI()
    {
        livesText.text = "Lives: " + remainingLives;
    }

    private void GameOver()
    {
        gameOverScreen.SetActive(true);
        // Implement game over logic here, like showing scores or options to restart.
    }
}