using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPlatform : MonoBehaviour
{
    private HighScore _scoreScript;
    private TimeScript _timeScript;
    private WinScript _winScript;
    void Start()
    {
        _timeScript = GameObject.FindGameObjectWithTag("TimeManager").transform.GetComponent<TimeScript>();
        _scoreScript = GameObject.FindGameObjectWithTag("ScoreManager").transform.GetComponent<HighScore>();
        _winScript = GameObject.FindGameObjectWithTag("LevelWin").transform.GetComponent<WinScript>();

    }
    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.transform.root.gameObject.CompareTag("Player"))
        {
            _scoreScript._completedLevel = true;
            _scoreScript.CalcTimeScore();
            _scoreScript.CalcScore();
            _winScript.SetScores();
            _timeScript.GameWon();
            yield return new WaitForSeconds(0.5f);
            Time.timeScale = 0;
        }
    }
}