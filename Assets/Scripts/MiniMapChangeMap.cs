using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class MiniMapChangeMap : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform _cameraTransform;
    [SerializeField] private Camera _camera1;
    [SerializeField] private Image _changedViewImage;
    [SerializeField] private Image _changedViewImage2;
    [SerializeField] private RawImage _changedViewRawImage;
    [SerializeField] private RawImage _changedViewRawImage2;

    private PlayerControls _playerControls;
    private Vector3 _offset;

    [SerializeField] private Transform _player;


    void Start()
    {
        _playerControls = new PlayerControls();
        _playerControls.Settings.ChangeMiniMap.Enable();
        _playerControls.Settings.ChangeMiniMap.performed += ChangeTheMiniMap;
        _playerControls.Settings.ChangeMiniMap.canceled += ChangeTheMiniMapCanceled;


        _changedViewImage.enabled = false;
        _changedViewImage2.enabled = true;
        _changedViewRawImage.enabled = false;
        _changedViewRawImage2.enabled = true;
    }
    private void ChangeTheMiniMap(InputAction.CallbackContext context)
    {
        MiniMapBig();
    }
    private void ChangeTheMiniMapCanceled(InputAction.CallbackContext context)
    {
        MiniMapSmall();
    }
    void Update()
    {

    }
    private void MiniMapSmall()
    {
        _changedViewImage.enabled = false;
        _changedViewImage2.enabled = true;
        _changedViewRawImage.enabled = false;
        _changedViewRawImage2.enabled = true;
    }
    private void MiniMapBig()
    {

        _changedViewImage.enabled = true;
        _changedViewImage2.enabled = false;
        _changedViewRawImage.enabled = true;
        _changedViewRawImage2.enabled = false;

    }
    private void Awake()
    {
        _offset = new Vector3(0, 500f, 0);
    }
    private void LateUpdate()
    {
        _cameraTransform.position = _player.transform.position + _offset;
    }
}
