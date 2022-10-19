using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI _highScoreEndText;

    private int _highScore;
    private int _score;

    private void Start()
    {
        _highScore = PlayerPrefs.GetInt("highscore");
        _highScoreEndText.text = "HIGHSCORE:" + _highScore;
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
