using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawn : MonoBehaviour
{
    [SerializeField] private List<GameObject> _enemyCarsList= new List<GameObject>();
    private GameObject _player;


    private Vector3 _enemySpawnPositon;

    [SerializeField] private float _additionalDistanceBetweenEnemyAndPlayer;
    [SerializeField] private float[] _xCoordinatesList = new float[3];
    
    private void Start()
    {
        InvokeRepeating("EnemySpawn", 0, 1);
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void EnemySpawn()
    {
        Instantiate(_enemyCarsList[GetIndexForEnemyCarList()], GetCoordinatesForEnemySpawn(), Quaternion.identity);
    }

    private Vector3 GetCoordinatesForEnemySpawn()
    {
        _enemySpawnPositon = new Vector3(_xCoordinatesList[Random.Range(0, 3)], 0, _player.transform.position.z + _additionalDistanceBetweenEnemyAndPlayer);
        return _enemySpawnPositon;
    }

    private int GetIndexForEnemyCarList()
    {
        return Random.Range(0, _enemyCarsList.Count);
    }
}
