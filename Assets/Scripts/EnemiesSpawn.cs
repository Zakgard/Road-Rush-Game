using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawn : MonoBehaviour
{
    [SerializeField] private List<GameObject> _enemyCarsList= new List<GameObject>();
    [SerializeField] private float zCoordinatesSpawn;
    private float _spawnDelay=1.0f;
    
    private Vector3 _enemySpawnPositon;
    
    [SerializeField] private float[] _xCoordinatesList = new float[3];
      
    
    private IEnumerator EnemySpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnDelay);
            Instantiate(_enemyCarsList[GetIndexForEnemyCarList()], GetCoordinatesForEnemySpawn(), Quaternion.identity);
        }       
    }

    private Vector3 GetCoordinatesForEnemySpawn()
    {
        _enemySpawnPositon = new Vector3(_xCoordinatesList[Random.Range(0, 3)], 0, zCoordinatesSpawn);
        return _enemySpawnPositon;
    }

    private int GetIndexForEnemyCarList()
    {
        return Random.Range(0, _enemyCarsList.Count);
    }

    private IEnumerator Start()
    {
        InvokeRepeating("DecreaseDelay", 10.0f, 10.0f);
        yield return StartCoroutine(EnemySpawn());
    }

    private void DecreaseDelay()
    {
        _spawnDelay -= 0.05f;
    }
}
