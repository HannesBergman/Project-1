using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    [Header("Set Volume Between 0 and 1")]
    [SerializeField] private float _jumpPadVolume;
    
    public float UpForce;
    public float ForwardForce;
    
    private Rigidbody _rigidbody;
    private AudioSource _jumpPadSFX;

    private bool _isActive;

    private void Start()
    {
        _jumpPadSFX = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.CompareTag("Player") && _isActive == false)
        {
            _rigidbody = other.transform.root.GetComponent<Rigidbody>();
            _rigidbody.AddForce(transform.up * UpForce);
            _rigidbody.AddForce(transform.forward * ForwardForce);
            _jumpPadSFX.PlayOneShot(_jumpPadSFX.clip, _jumpPadVolume);           
            _isActive = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        _isActive = false;
    }
}

