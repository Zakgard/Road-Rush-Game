using UnityEngine;

public class TreesSpawnAtStart : MonoBehaviour
{
    [SerializeField] private GameObject[] _treesArray = new GameObject[4];
    [SerializeField] private Vector3[] _bounds = new Vector3[5];

    private void Start()
    {
        SpawnTrees();
    }

    private void SpawnTrees()
    {
        for(int i = (int)_bounds[0].z; i < (int)_bounds[4].z; i+=10)
        {
            for(int j = (int)_bounds[0].x; j < (int)_bounds[1].x; j += 5)
            {
                Instantiate(_treesArray[GetTreeIndexToSpawn()], new Vector3(j, 0, i), Quaternion.identity);
                Debug.Log($"{j}, 0, {i}");
            }

            for (int j = (int)_bounds[2].x; j < (int)_bounds[3].x; j += 5)
            {
                Instantiate(_treesArray[GetTreeIndexToSpawn()], new Vector3(j, 0, i), Quaternion.identity);
                Debug.Log($"{j}, 0, {i}");
            }

        }
    }

    private int GetTreeIndexToSpawn()
    {
        return Random.Range(0, 4);
    }
}
    
