using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupManager : MonoBehaviour
{
    private static PickupManager s_instence;

    //[SerializeField] private GameObject _pickupPrefab1;
    //[SerializeField] private GameObject _pickupPrefab2;
    //[SerializeField] private GameObject _pickupPrefab3;

    //[SerializeField] public int _maxAmountTrash1;
    //private int _currentAmoutTrash1;

    //private GameObject[] _currentAmountTrashSpawned = new GameObject[_maxAmountTrash1];
    //[SerializeField] private int _maxAmountTrash2;
    //private int _currentAmoutTrash2;
    //[SerializeField] private int _maxAmountTrash3;
    //private int _currentAmoutTrash3;
    

    //[SerializeField] private float _spawnAreaMin_x;
    //[SerializeField] private float _spawnAreaMax_x;
    //[SerializeField] private float _spawnAreaMin_z;
    //[SerializeField] private float _spawnAreaMax_z;

    private int maxTotalTrash;

    private void Awake()
    {
        if (s_instence == null)
        {
            s_instence = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    
    public static PickupManager GetInstence()
    {
        return s_instence;
    }
    
}



