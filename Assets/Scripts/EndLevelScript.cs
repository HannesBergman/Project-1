using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndLevelScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreEndText;
    [SerializeField] private TextMeshProUGUI _highScoreEndText;
    [SerializeField] private GameObject _scoreManager;

    private HighScore _highScore;
    

    private void Start()
    {
        _highScore = _scoreManager.GetComponent<HighScore>();
        
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
    public void EndScreenScore() //Run this in a OnTriggerEnter on the finishline object
    {
        _highScore.CalcTimeScore();
        _highScore.CalcScore();
        _highScore.SetHighScore();
        _scoreEndText.text = "SCORE: " + _highScore.TotalScore;
        _highScoreEndText.text = "HIGHSCORE: " + _highScore.PlayerHighScore;
       
    }

}
