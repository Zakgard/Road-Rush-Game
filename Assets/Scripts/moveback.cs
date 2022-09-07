using UnityEngine;

public class moveback : MonoBehaviour
{
    [SerializeField] private GameObject _roadObjectGO;

    private Rigidbody _roadObjectRB;
    [SerializeField]private Vector3 _roadObjectMovingDirection;
    

    private void Start()
    {
        _roadObjectRB = _roadObjectGO.GetComponent<Rigidbody>();

    }
    private void FixedUpdate()
    {
        _roadObjectRB.MovePosition(_roadObjectRB.position + _roadObjectMovingDirection);
    }
}
