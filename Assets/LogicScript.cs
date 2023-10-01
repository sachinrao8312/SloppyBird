using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text CurrentScore;
    public GameObject gameOverScreen ;

    [ContextMenu("Increase Score")]
    public void AddScore(int add)
    {
        playerScore = playerScore + add;
        CurrentScore.text = playerScore.ToString();
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
    public void RestartGame()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
