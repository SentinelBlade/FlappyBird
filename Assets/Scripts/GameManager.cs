using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public GameObject getReady;
    public Player player;
    public Text hiscoreText;
    private int score;


    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
        getReady.SetActive(true);
    }
    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();
        hiscoreText.text = LoadHiscore().ToString();
        getReady.SetActive(false);
        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);

        }
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
        gameOver.SetActive(false);
    }
    public void GameOver()
    {
        SaveHiscore();
        Time.timeScale = 0f;
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Debug.Log("Game over");
        player.enabled = false;
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        Debug.Log("Score" + score);
    }
    private void SaveHiscore()
    {
        int hiscore = LoadHiscore();
        if (score > hiscore)
        {
            PlayerPrefs.SetInt("hiscore", score);
        }
    }
    private int LoadHiscore()
    {
        return PlayerPrefs.GetInt("hiscore", 0);
    }
}
