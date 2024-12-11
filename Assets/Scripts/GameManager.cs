using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;
    public Text finalScore;
    public AudioSource gameOverAudioSource;
    public AudioClip gameOverAudioClip;


    private void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        gameOverAudioSource.PlayOneShot(gameOverAudioClip);
        gameOverCanvas.SetActive(true);
        scoreCanvas.SetActive(false);
        finalScore.text = $"Your Score is: {Score.score}";

        Time.timeScale = 0;
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
