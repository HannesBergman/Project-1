using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField] private AudioSource soundtrack;
    private PlayerMovement _playerMovement;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerMovement=GetComponent<PlayerMovement>();
        
        soundtrack.loop = false;
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
        
        
        if (Input.GetAxis("Vertical") != 0)
        {
            
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            soundtrack.Play();
            soundtrack.loop = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            soundtrack.Stop();
            soundtrack.loop = false;
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            soundtrack.Play();
            soundtrack.loop = true;
            
        }
        {
            soundtrack.Stop();
            soundtrack.loop = false;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            soundtrack.Stop();
            soundtrack.loop = false;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            soundtrack.Play();
            soundtrack.loop = true;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            soundtrack.Stop();
            soundtrack.loop = false;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            soundtrack.Play();
            soundtrack.loop = true;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            soundtrack.Stop();
            soundtrack.loop = false;
        }
    }
}
