using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro.Examples;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class SoundControl : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    //[SerializeField] private Transform _player;
    
    [SerializeField] private List<AudioClip> _walkSounds = new List<AudioClip>();
    [SerializeField] private List<AudioClip> _jumpSounds = new List<AudioClip>();
    [SerializeField] private List<AudioClip> _inAirSounds = new List<AudioClip>();
    [SerializeField] private List<AudioClip> _slidingSounds = new List<AudioClip>();
    [SerializeField] private List<AudioClip> _crouchingSounds = new List<AudioClip>();
    [SerializeField] private List<AudioClip> _sprintingSounds = new List<AudioClip>();
    [SerializeField] private List<AudioClip> _trashPickUpSound = new List<AudioClip>();
    [SerializeField] private List<AudioClip> _winSounds = new List<AudioClip>();
    [SerializeField] private List<AudioClip> _loseSounds = new List<AudioClip>();

    [SerializeField] private List<List<AudioClip>> _soundsList = new List<List<AudioClip>>();

    


    private PlayerMovement _playerMovement;
    
    private float _volume;
    private int _currentSound;
    private int _currentArray;
    private int _currentRandom;
    
    private int _randomWalkSound;
    private int _randomJumpSound;
    private int _randomInAirSound;
    private int _randomSlidingSound;
    private int _randomCrouchingSound;
    private int _randomSprintingSound;
    private int _randomTrashPickUpSound;
    private int _randomWinSound;
    private int _randomLoseSound;

    private void Start()
    {
        //_playerMovement = _player.GetComponent<PlayerMovement>();

        _soundsList.Add(_walkSounds);
        _soundsList.Add(_jumpSounds);
        _soundsList.Add(_inAirSounds);
        _soundsList.Add(_slidingSounds);
        _soundsList.Add(_crouchingSounds);
        _soundsList.Add(_sprintingSounds);
        _soundsList.Add(_trashPickUpSound);
        _soundsList.Add(_winSounds);
        _soundsList.Add(_loseSounds);
    }
    private void Awake()
    {
        PlayerPrefs.GetFloat("volume", _volume);
        AudioListener.volume = PlayerPrefs.GetFloat("volume");
    }
    private void Update()
    {
        //_soundsList[_currentArray][_currentSound].gameObject.transform.position = _player.position;
    }
    /*public void ChangeSound(int num)
    {
        _currentSound = num;
        for (int i = 0; i < _soundsList[_currentArray].Count; i++)
        {
            if (i == num)
            {
                _soundsList[_currentArray][_currentSound].Play();
            }
            else
            {
                _soundsList[_currentArray][_currentSound].Stop();
            }
        }
    }*/
    public AudioClip ChangeSoundList(List<AudioClip> num)
    {
        AudioClip something = num[Random.Range(0, num.Count - 1)];
        return something;
    }
    public void WalkingSound()
    {
        _audioSource.clip = ChangeSoundList(_walkSounds);
        _audioSource.PlayOneShot(_audioSource.clip);
        if (!_audioSource.isPlaying)
        {
        }
    }
    public void JumpSound()
    {
        if (!_audioSource.isPlaying)
        {
            _audioSource.clip = ChangeSoundList(_jumpSounds);
            _audioSource.PlayOneShot(_audioSource.clip);
        }
    }
    public void InAirSound()
    {
        /*if (!_audioSource.isPlaying)
        {
            _audioSource.clip = ChangeSoundList(_inAirSounds);
            _audioSource.PlayOneShot(_audioSource.clip);
        }*/
    }
    public void SlidingSound()
    {
        if (!_audioSource.isPlaying)
        {
            _audioSource.clip = ChangeSoundList(_slidingSounds);
            _audioSource.PlayOneShot(_audioSource.clip);
        }
    }
    public void SprintingSound()
    {
        if (!_audioSource.isPlaying)
        {
            _audioSource.clip = ChangeSoundList(_sprintingSounds);
            _audioSource.PlayOneShot(_audioSource.clip);
        }
    }
    public void TrashPickUpSound()
    {
        if (!_audioSource.isPlaying)
        {
            _audioSource.clip = ChangeSoundList(_trashPickUpSound);
            _audioSource.PlayOneShot(_audioSource.clip);
        }
    }
    public void WinSound()
    {

    }
    public void LoseSound()
    {

    }
}
