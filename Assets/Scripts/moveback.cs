using UnityEngine;

public class moveback : MonoBehaviour
{
    [SerializeField] private GameObject _roadObjectGO;

    private Rigidbody _roadObjectRB;
    [SerializeField] private Vector3 _roadObjectMovingDirection;
    
    public static float speed;
    private void Start()
    {
        _roadObjectRB = _roadObjectGO.GetComponent<Rigidbody>();       
    }
    private void FixedUpdate()
    {        
        _roadObjectRB.MovePosition(_roadObjectRB.position + new Vector3(0,0, _roadObjectMovingDirection.z*speed));        
    }
    
}
