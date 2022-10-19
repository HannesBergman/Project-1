using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OilSpill : MonoBehaviour
{
    [Header("Set Volume Between 0 and 1")]
    [SerializeField] private int _oilSpillSFXVolume;

    private AudioSource _oilSpillSFX;

    private void Start()
    {
        _oilSpillSFX = GetComponent<AudioSource>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.CompareTag("Player"))
        {
            _oilSpillSFX.volume = _oilSpillSFXVolume;
            _oilSpillSFX.Play();
            

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.root.CompareTag("Player"))
        {
            _oilSpillSFX.Stop();
        }
    }

}
