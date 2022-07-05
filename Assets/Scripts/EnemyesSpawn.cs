using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyesSpawn : MonoBehaviour
{
    [Header("Объект враг")]
    [SerializeField] private List<GameObject> _enemiesList;

    [Header("Объект игрок")]
    [SerializeField] private GameObject _player;

    [SerializeField] private float _enemiesCount;

    private float[] _coordinatesToSpawnX = new float[3] {-10,0,10};

    private void Start()
    {
        StartCoroutine(SpawnTheEnemy());  
    }
    private IEnumerator SpawnTheEnemy()
    {       
        while (true)
        {
            Instantiate(_enemiesList[Random.Range(0, _enemiesList.Count)], GetPlaceToSpawn(), Quaternion.identity);
            _enemiesCount++;
            yield return new WaitForSeconds(1f);
        }
                      
    }

    private Vector3 GetPlaceToSpawn()
    {
        return new Vector3(_coordinatesToSpawnX[Random.Range(0, _coordinatesToSpawnX.Length)], 0, _player.transform.position.z + 360);
    }
}
