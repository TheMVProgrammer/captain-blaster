using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Image gameOverImage;

    int playerScore = 0;
    public void AddScore()
    {
        playerScore++;
        // This converts the score (a number) into a string
        scoreText.text = playerScore.ToString();
    }
    public void PlayerDied()
    {
        gameOverImage.gameObject.SetActive(true);
        // This freezes the game
        Time.timeScale = 0;
    }
}
