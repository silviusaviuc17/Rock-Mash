using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript1 : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    void Start(){
      
      gameOverScreen.SetActive(false);
      
      }

    public void addScore(int scoreToAdd)
    { Debug.Log("Score added: " + scoreToAdd);
    
    playerScore = playerScore + scoreToAdd;
    scoreText.text = playerScore.ToString();
    }
    public void restartGame()
     {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);

     }

    public void gameOver()
     {
      Debug.Log("Game Over method called!");
        gameOverScreen.SetActive(true);
     }
}
