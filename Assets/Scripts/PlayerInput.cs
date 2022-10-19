using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private PlayerControls _playerControls;

    private void Start()
    {
        _playerControls = new PlayerControls();
        _playerControls.Player.Throw.Enable();
        _playerControls.Player.Throw.performed += Throw;
        _playerControls.Player.Move.Enable();
        _playerControls.Player.Move.performed += Move;
    }

    public void Move(InputAction.CallbackContext context)
    {
       
    }
    private void Throw(InputAction.CallbackContext context)
    {
   
    }
    private void Update()
    {
        
    }
}
