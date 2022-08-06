using UnityEngine;

public class RoadMovingBack : MonoBehaviour
{
    [SerializeField] private GameObject _roadGO;

    private Rigidbody _roadRB;

    private Vector3 _roadMovingDirection = new Vector3(0, 0, -1f);
    private void Start()
    {
        _roadRB=_roadGO.GetComponent<Rigidbody>();
    }    
    private void FixedUpdate()
    {
        _roadRB.MovePosition(_roadRB.position+_roadMovingDirection);
    }
}
