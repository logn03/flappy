using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public GameObject gameOver;


    public void AddScore(int ScoreToAdd)
    {
        score = score + ScoreToAdd;
        scoreText.text = score.ToString();
    }


    public void ResetScore()
    {
        score = 0;
        scoreText.text = score.ToString();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void GameOver() 
    {
        gameOver.SetActive(true);
    }
}
