using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public int highScore;
    public Text highScoreText;
    public GameObject gameOverScreen;
    public BirdScript player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<BirdScript>();
        highScoreText.text = "HIGHSCORE: " + PlayerPrefs.GetInt("highscore", 0).ToString();
    }

    public void addScore()
    {
        if (player.birdIsAlive)
        {
            playerScore += 1;
            scoreText.text = playerScore.ToString();
        }

        if (playerScore > PlayerPrefs.GetInt("highscore", 0))
        {
            PlayerPrefs.SetInt("highscore", playerScore);
            highScoreText.text = "HIGHSCORE: " + playerScore.ToString();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Application has been quit.");
    }
}
