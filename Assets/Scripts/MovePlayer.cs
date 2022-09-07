using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [Header("Объект игрок")]
    [SerializeField] private GameObject _playerGO;

    private Rigidbody _playerRigidbody;
    public float speed;

    [SerializeField] private Vector3 _playersLeftBound=new Vector3(-11,0,-210);
    [SerializeField] private Vector3 _playersRightBound = new Vector3(11, 0, -210);
    

    private void Start()
    {
        _playerRigidbody = _playerGO.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {                
        CheckIfPlayerOutOfBounds();       
    }
   
    private void CheckIfPlayerOutOfBounds()
    {       
        if(_playerRigidbody.position.x < _playersLeftBound.x)
            _playerRigidbody.MovePosition(_playersLeftBound);
        if(_playerRigidbody.position.x > _playersRightBound.x)
            _playerRigidbody.MovePosition(_playersRightBound);
    }         
}
