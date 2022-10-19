using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailSafe : MonoBehaviour
{
    [SerializeField] private Transform _gameObject;
    [SerializeField] private float _lowestPoint;
    
    private Transform _player;
    private float _playerYpos;


    private void Start()
    {
        _player = GetComponent<Transform>();
        _gameObject = _gameObject.GetComponent<Transform>();
    }
    private void Update()
    {
        PlayerPos();
        RestartField();
    }
    private void PlayerPos()
    {
        _playerYpos = _player.transform.position.y;
    }
    private void RestartField()
    {
        if(_playerYpos < _lowestPoint)
        {
            _player.transform.position = _gameObject.transform.position;
        }
    }

}
