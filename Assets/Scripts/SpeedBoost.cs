using JetBrains.Rider.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    [Header("Set Volume Between 0 and 1")]
    [SerializeField] private float _soundSFXVolume;
    [SerializeField] private float _speedUpSpeed;
    //[SerializeField] private Transform _camera;

    private PlayerMovement _playerMovement;
    private Rigidbody _rb;
    private AudioSource _speedSFX;
    private bool _isActive;
    //private Vector3 _cameraDirection;
    


    private void Start()
    {
        _speedSFX = GetComponent<AudioSource>();


    }
    private void Update()
    {
        
        //_cameraDirection = _camera.TransformDirection(Vector3.forward);
        //_cameraDirection.y = 0f;
        

    }

    private void OnTriggerEnter(Collider other)
    {
        
        _playerMovement = other.transform.root.GetComponent<PlayerMovement>();
        _rb = other.transform.root.GetComponent<Rigidbody>();
        if (other.transform.root.CompareTag("Player") && _isActive == false)
        {
            _rb.AddForce(transform.forward * _speedUpSpeed, ForceMode.Impulse);
            _speedSFX.PlayOneShot(_speedSFX.clip, _soundSFXVolume);
            _isActive = true;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        _isActive = false;
    }
}
