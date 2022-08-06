using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [Header("Объект игрок")]
    [SerializeField] private GameObject _player;

    private Rigidbody _playerRigidbody;   

    private void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {        
        _playerRigidbody.MovePosition(_playerRigidbody.position + _movementVector);        
    }

    private Vector3 _movementVector
    {
        get
        {
            var horizontal = Input.GetAxis("Horizontal");           
            return new Vector3(horizontal*0.5f, 0.0f, 1);
        }
    }
}
