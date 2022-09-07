using UnityEngine;

public class RoadSpawnOnStartPosition : MonoBehaviour
{
    [SerializeField] private GameObject _roadGO;
     private Rigidbody _roadRB;
    [SerializeField] private Vector3 _roadStartPosition;

    private void Start()
    {
        _roadRB= _roadGO.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if(_roadRB.position.z-_roadStartPosition.z<=-150)
            _roadRB.position=_roadStartPosition;
    }
}
