using UnityEngine;

public class AdvertiseStandSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _advertiseStand;
    [SerializeField] private Vector3 _spawnPosition;
    [SerializeField] private Vector3 _bounds;
    private Rigidbody _advertiseStandRB;

    private void Start()
    {
        _advertiseStandRB = _advertiseStand.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_advertiseStandRB.position.z < _bounds.z)
            _advertiseStandRB.MovePosition(_spawnPosition);
    }
}
