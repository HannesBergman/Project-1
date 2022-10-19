using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject _pickupPrefab1;
    [SerializeField] private int _maxAmountTrash1;
    [SerializeField] private float _respawnRate;
    [SerializeField] private float _timer;

    public int _currentTrashAmount1;
    private int _currentTrashAmountAtStart;
    public List<GameObject> _Trashh = new List<GameObject>();
    private Collider[] _hitCollider;


    [SerializeField] private float _spawnAreaMin_x;
    [SerializeField] private float _spawnAreaMax_x;
    [SerializeField] private float _spawnAreaMin_z;
    [SerializeField] private float _spawnAreaMax_z;

    private bool _isIfSpawnable;



    private void Start()
    {

        _isIfSpawnable = true;
    }
    private void Update()
    {
        SpawnOnStart();
        InvokeRepeating("SpawnIsItSpawnable", 10f, 10f);
    }

    public void SpawnTrash1()
    {

        //if(_currentTrash < _maxAmountTrash1)
        //{
        //    _currentTrash++;
        //    GameObject newTrash1 = Instantiate(_pickupPrefab1);
        //    _Trashh.Add(newTrash1);
        //    foreach(GameObject trash in _Trashh)
        //    {
        //        trash.transform.position = new Vector3(Random.Range(_spawnAreaMin_x, _spawnAreaMax_x), 1, Random.Range(_spawnAreaMin_z, _spawnAreaMax_z));
        //    }
        //}
    }
    public void SpawnIsItSpawnable()
    {
        if (_isIfSpawnable == true && _currentTrashAmount1 >= _currentTrashAmountAtStart)
        {
            for (int i = _currentTrashAmount1; i <= _maxAmountTrash1; i++)
            {
                _currentTrashAmount1++;
                GameObject newTrash1 = Instantiate(_pickupPrefab1);
                _Trashh.Add(newTrash1);

                foreach (GameObject trash in _Trashh)
                {
                    trash.transform.position = new Vector3(Random.Range(_spawnAreaMin_x, _spawnAreaMax_x), 1, Random.Range(_spawnAreaMin_z, _spawnAreaMax_z));

                }

            }
        }
        if (_isIfSpawnable == false)
        {
            IsItSpawnable();
        }
    }
    private void SpawnOnStart()
    {
        if (_isIfSpawnable == true)
        {
            for (int i = _currentTrashAmountAtStart; i <= _maxAmountTrash1; i++)
            {
                _currentTrashAmountAtStart++;
                GameObject newTrash1 = Instantiate(_pickupPrefab1);
                _Trashh.Add(newTrash1);
                foreach (GameObject trash in _Trashh)
                {
                    trash.transform.position = new Vector3(Random.Range(_spawnAreaMin_x, _spawnAreaMax_x), 1, Random.Range(_spawnAreaMin_z, _spawnAreaMax_z));
                }
            }
        }
    }


    private void IsItSpawnable()
    {

        foreach (GameObject trash in _Trashh)
        {
            _hitCollider = Physics.OverlapSphere(trash.transform.position, 3f);


            foreach (Collider collider in _hitCollider)
            {
                if (collider.tag == "trash")
                {
                    _isIfSpawnable = false;
                }

                else
                {
                    _isIfSpawnable = true;
                }
            }
        }
    }
}
