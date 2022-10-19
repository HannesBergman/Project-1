using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPad : MonoBehaviour
{
    [Header("Set Volume Between 0 and 1")]
    [SerializeField] private float _SFXVolume;
    [SerializeField] public Transform TeleportTo;
    private AudioSource _teleportSFX;
    private void Start()
    {
        _teleportSFX = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.CompareTag("Player"))
        {
            other.transform.root.position = TeleportTo.transform.position;
            _teleportSFX.PlayOneShot(_teleportSFX.clip, _SFXVolume);
        }
    }
}
