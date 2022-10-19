using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MiniMap : MonoBehaviour
{
    private Transform _player;

    [SerializeField] private float _minimapCameraZoomSize1;
    [SerializeField] private float _minimapCameraZoomSize2;
    [SerializeField] private float _minimapCameraZoomSize3;
    [SerializeField] private float _minimapCameraZoomSize4;
    [SerializeField] private Camera _minimapCamera;
    private PlayerControls _playerControlls;
    private Vector3 _offset;
    private int _num;


    private void Start()
    {
        _playerControlls = new PlayerControls();
        _playerControlls.Settings.ChangeMiniMapZoom.Enable();
        _playerControlls.Settings.ChangeMiniMapZoom.performed += ChangeMiniMapView;
        _player = GameObject.FindGameObjectWithTag("Player").transform.GetComponent<Transform>();
    }
    //Remove the method below and just call the ChangeCameraSize(); from the PlayerInput script
    private void ChangeMiniMapView(InputAction.CallbackContext context)
    {
        ChangeCameraSize();
    }
    
    private void Awake()
    {
        _offset = new Vector3(0, 500, 0);
    }
    
    public void ChangeCameraSize()
    {
        if (_num == 4)
        {
            _num = 1;
        }
        else
        {
            _num++;
        }
        if (_num == 1)
        {
            _minimapCamera.orthographicSize = _minimapCameraZoomSize1;
        }
        if (_num == 2)
        {
            _minimapCamera.orthographicSize = _minimapCameraZoomSize2;
        }
        if (_num == 3)
        {
            _minimapCamera.orthographicSize = _minimapCameraZoomSize3;
        }
        if (_num == 4)
        {
            _minimapCamera.orthographicSize = _minimapCameraZoomSize4;
        }
    }
    private void LateUpdate()
    {
        gameObject.transform.position = _player.position + _offset;
    }
}


