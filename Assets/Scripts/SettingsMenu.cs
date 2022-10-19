using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _yesText;
    [SerializeField] private TextMeshProUGUI _noText;
    [SerializeField] private TextMeshProUGUI _areYouSureText;
    [SerializeField] private TextMeshProUGUI _currentHighScore;

    [SerializeField] private Image _areYouSure;
    [SerializeField] private Image _image1;
    [SerializeField] private Image _image2;
    [SerializeField] private Image _yesImage;
    [SerializeField] private Image _noImage;
    
    public Slider _slider;
    private float _newVolume;
    private float volume;
    private int _highScore;
    private int _resetHighScoreNum;

    public void Update()
    {
        _newVolume = _slider.value;
        if(_newVolume != volume)
        {
            volume = _newVolume;
            ChangeVolume();
        }
        _currentHighScore.text = "CURRENT HIGHSCORE: " + _highScore;
    }
    private void Start()
    {
        
    }
    private void Awake()
    {
        _highScore = PlayerPrefs.GetInt("highscore", 0);
        
    }
    public void ResetHighScoreButton()
    {

    }
    public void SaveSettings()
    {
        PlayerPrefs.Save();
    }
    public void ChangeVolume()
    {
        PlayerPrefs.SetFloat("volume", volume);
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }
    public void YesButton()
    {
        PlayerPrefs.SetInt("highscore", 0);
        _highScore = PlayerPrefs.GetInt("highscore");
        _currentHighScore.text = "CURRENT HIGHSCORE: " + _highScore;
    }
    public void NoButton()
    {

    }
}
