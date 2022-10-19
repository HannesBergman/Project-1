using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public static int PlayerScore;
    public int PlayerHighScore;
    public static int ResetPlayerHighScore = 0;
    public int TotalScore;
    public static int TimeScore;
    [Header("In Seconds")]
    public float MaxTimeForLevel;
    private float _timeSpentOnLevel;
    private float _timeLeft;
    public bool _completedLevel;
    public static int i_timeScore;
    private static int i_timeLeft;
    
    
    [SerializeField] private TextMeshProUGUI _textScore;
    [SerializeField] private TextMeshProUGUI _textHighScore;
    //[SerializeField] private GameObject _playerPrefab;

    private void Start()
    {
        PlayerScore = 0;

        PlayerHighScore = PlayerPrefs.GetInt("highscore", PlayerHighScore);
        _textHighScore.text ="HIGHSCORE: " + PlayerHighScore.ToString();
    }
    void Update()
    {
        _textScore.text = "SCORE: " + PlayerScore.ToString();
        _timeSpentOnLevel += Time.deltaTime;


    }
    private void ResetHighScore()
    {
        PlayerPrefs.SetInt("highscore", ResetPlayerHighScore);
        PlayerHighScore = ResetPlayerHighScore;
    }
    public void CalcScore() // Also call this method
    {
        if(_completedLevel == true)
        {
            TotalScore = PlayerScore + i_timeScore;
        }
        else
        {
            TotalScore = 0;
        }
    }
    public void CalcTimeScore()  //On the finish line reference this method
    {
        if(_completedLevel == true)
        {
            _timeLeft = MaxTimeForLevel - _timeSpentOnLevel;
            i_timeScore = (int)TimeScore;
            i_timeLeft = (int)_timeLeft;
            i_timeScore *= 25;
        }
        else
        {
            i_timeScore = 0;
        }
    }
    public void SetHighScore()
    {
        if (TotalScore >= PlayerHighScore)
        {
            PlayerHighScore = TotalScore;
            PlayerPrefs.SetInt("highscore", PlayerHighScore);
        }
    }
}
