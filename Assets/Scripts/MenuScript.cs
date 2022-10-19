using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    
    private static int _highScore;

    private void Start()
    {
        _highScore = PlayerPrefs.GetInt("highscore", 0);
              
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitButton()
    {
        PlayerPrefs.Save();
        Application.Quit();
    }
}
