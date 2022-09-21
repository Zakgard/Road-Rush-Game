using UnityEngine;

public class SpawnRepairTool : MonoBehaviour
{
    [SerializeField] private float[] _xCoordinatesSpawnForTools=new float[3];
    [SerializeField] private float _toolsSpawnDelay;
    [SerializeField] private float _toolsSpawnInterval;
    [SerializeField] private GameObject _repairToolGO;
    [SerializeField] private float zCoordinatesSpawn;

    private void Start()
    {
        InvokeRepeating("SpawnTheTool", _toolsSpawnDelay, _toolsSpawnInterval);
    }

    private void SpawnTheTool()
    {
        Instantiate(_repairToolGO, GetSpawnPosition(), Quaternion.identity);
    }

    private Vector3 GetSpawnPosition()
    {
        return new Vector3(_xCoordinatesSpawnForTools[Random.Range(0, 3)], 2, zCoordinatesSpawn);
    }
}
