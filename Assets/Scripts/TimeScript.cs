using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class TimeScript : MonoBehaviour
{
    [SerializeField] private Image _time;
    //[SerializeField] private TextMeshProUGUI _gameOver;
    [SerializeField] private RectTransform _gameFail;
    [SerializeField] private RectTransform _gameWin;
    [SerializeField] private GameObject _levelFail;
    [SerializeField] private GameObject _levelWin;

    [SerializeField] private Vector2 _positionToMoveTo;

    [SerializeField] private float _maxTime;
    [SerializeField] private float _addTime;

    private GameObject[] _trashArray;


    private float _currentTime;
    private float _maxAddbleTime;
    

    private bool _isDone = false;


    private void Start()
    {
        _currentTime = _maxTime;
        _time.fillAmount = 1f;
        //_gameOver = _gameOver.GetComponent<TextMeshProUGUI>();
        //_gameFail = _levelFail.GetComponent<RectTransform>();
        _levelFail = GameObject.FindGameObjectWithTag("LevelFail");
        _levelWin = GameObject.FindGameObjectWithTag("LevelWin");
        _trashArray = GameObject.FindGameObjectsWithTag("trash");
        _levelWin.SetActive(false);
        _levelFail.SetActive(false);
    }
    private void Update()
    {
        Timer();
       
    }
    private void Timer()
    {
        _currentTime -= Time.deltaTime;
        _time.fillAmount = _currentTime / _maxTime;
        if (_currentTime <= 0 && _isDone == false)
        {
            _isDone = true;
            //_gameOver.enabled = true;
            DestroyTrash();

            StartCoroutine(GameOver());
        }
    }
    private void DestroyTrash()
    {
        foreach (GameObject trash in _trashArray)
        {
            Destroy(trash);
        }
    }
    private IEnumerator GameOver()
    {
        
        yield return new WaitForSeconds(1);
        _levelFail.SetActive(true);
        StartCoroutine(GameOverTextPosition(_positionToMoveTo, 0.2f));
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 0;

    }
    public void GameWon()
    {
        _levelWin.SetActive(true);
        StartCoroutine(WinGamePopupWindow(_positionToMoveTo, 0.2f));
        
    }
    private IEnumerator WinGamePopupWindow(Vector2 targetPosition, float duration)
    {
        float time = 0;
        Vector2 startPosition = _gameWin.anchoredPosition;
        while (time < duration)
        {
            _gameWin.anchoredPosition = Vector2.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        _gameWin.anchoredPosition = targetPosition;
    }
    private IEnumerator GameOverTextPosition(Vector2 targetPosition, float duration)
    {
        float time = 0;
        Vector2 startPosition = _gameFail.anchoredPosition;
        while (time < duration)
        {
            _gameFail.anchoredPosition = Vector2.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        _gameFail.anchoredPosition = targetPosition;
    }
    private float MaxAddbleTime()
    {
        if (_currentTime + _addTime <= _maxTime)
        {
            return _addTime;
        }
        else
        {
            _maxAddbleTime = _maxTime - _currentTime;
            return _maxAddbleTime;
        }
    }
    public void GetMoreTime()
    {
        _currentTime += MaxAddbleTime();        
    }
}
