using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;

    private TimeScript _timeScript;
    private HighScore _scoreScript;
    private int _highScore;
    private int _score;
    private void Start()
    {
        _scoreScript = GameObject.FindGameObjectWithTag("ScoreManager").transform.GetComponent<HighScore>();

        
        

    }
    public void SetScores()
    {
        _score = _scoreScript.TotalScore;

        _highScore = PlayerPrefs.GetInt("highscore");
        _highScoreText.text = "HIGHSCORE:" + _highScore;
        _scoreText.text = "SCORE: " + _score;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void SettingsButton()
    {

    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void MainMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
