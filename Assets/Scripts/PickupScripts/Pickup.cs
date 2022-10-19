using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pickup : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject _pickupPrefab1;
    //[SerializeField] private GameObject _timeLeftObject;
    private TimeScript _timeScript;
    private SoundControl _soundControl;
    private void Start()
    {
        _timeScript = GameObject.FindGameObjectWithTag("TimeManager").transform.GetComponent<TimeScript>();
        _soundControl = GameObject.FindGameObjectWithTag("SoundControl").transform.GetComponent<SoundControl>();
    }

    public void Interact()
    {
        //Type whatever is supposed to happen whenever a pickup with this script is collected by the player
        HighScore.PlayerScore += 100;
        _soundControl.TrashPickUpSound();
        //_timeLeftObject = GameObject.FindGameObjectWithTag("TimeLeft");
        //_timeScript = _timeLeftObject.GetComponent<TimeScript>();
        _timeScript.GetMoreTime();

        Destroy(gameObject);
        
    }
}
