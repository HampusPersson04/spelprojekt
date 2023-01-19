using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int level;
    private int lives;
    private int score;

    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        lives = 1;
        score = 0;
    }

    public void LevelComplete()
    {
        score += 1000;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LevelFailed()
    {
        lives--;

        if (lives <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}