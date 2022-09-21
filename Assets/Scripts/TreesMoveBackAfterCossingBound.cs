using UnityEngine;

public class TreesMoveBackAfterCossingBound : MonoBehaviour
{
    [SerializeField] private GameObject _treeGO;
    [SerializeField] private Vector3 _bounds;
    [SerializeField] private Vector3 _spawnPosition;
    

    private void Start()
    {
        _spawnPosition.x = _treeGO.transform.position.x;
        
    }
    private void Update()
    {
        if (transform.position.z < _bounds.z)
            _treeGO.transform.SetPositionAndRotation(_spawnPosition, Quaternion.identity);
    }
}
