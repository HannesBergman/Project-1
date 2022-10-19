using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class CanvasSpeedScript : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    private Rigidbody _rb;
    private float _speed;
    [SerializeField] private TextMeshProUGUI _textVectorSpeed;
    [SerializeField] private TextMeshProUGUI _textSpeed;
    
    void Start()
    {
        _rb = _player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       // _textVectorSpeed.text = "VECTOR SPEED: " + _rb.velocity.ToString();
        //_textSpeed.text = "SPEED: " + (_rb.velocity.x + _rb.velocity.z + _rb.velocity.y).ToString();
        _textSpeed.text = "SPEED: " + /*Mathf.Round*/(_rb.velocity.magnitude).ToString();
        
    }
}
