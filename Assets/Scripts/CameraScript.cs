using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private Vector3 _offsetPos;
    [SerializeField] private float _xRotationSpeed;
    [SerializeField] private float _yRotationlSpeed;
    private float _yRotation = 0f;
    private float _xRotation = 0f;
    private PlayerControls _playerControls;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        transform.GetChild(0).transform.localPosition = _offsetPos;
        _playerControls = new PlayerControls();
        _playerControls.Player.Look.Enable();
        _playerControls.Player.Look.performed += Look;
    }
    private void Look(InputAction.CallbackContext context)
    {
        
        Vector2 mouseDelta = context.ReadValue<Vector2>();
       /* transform.RotateAround(_player.transform.position, transform.up, mouseDelta.x);
        transform.RotateAround(_player.transform.position, transform.forward, mouseDelta.y);*/
        _yRotation += mouseDelta.x * _xRotationSpeed;
        _xRotation -= mouseDelta.y * _yRotationlSpeed;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f); 
        // twick clamps
        transform.rotation = Quaternion.Euler(_xRotation, _yRotation, 0);
        //allow for passing through textures?
    }
}
