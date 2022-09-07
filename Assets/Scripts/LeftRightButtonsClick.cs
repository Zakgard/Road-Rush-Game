using UnityEngine;

public class LeftRightButtonsClick : MonoBehaviour
{
    private GameObject _playerGO;
    private Rigidbody _playerRB;
    private Vector3 _moveLeftVector = new Vector3(-0.5f, 0, 0);
    private Vector3 _moveRightVector = new Vector3(0.5f, 0, 0);
    private Vector3 _stopHorizontalMovingVector = new Vector3(0, 0, 0);
    private Vector3 _moveDirection;

    private void Start()
    {
        _playerGO = GameObject.FindGameObjectWithTag("Player");
        _playerRB=_playerGO.GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate()
    {
        _playerRB.MovePosition(_playerRB.position + _moveDirection);
    }

    public void OnRightButtonClick()
    {
        _moveDirection= _moveRightVector;       
    }

    public void OnLeftButtonClick()
    {
        _moveDirection= _moveLeftVector;      
    }

    public void StopHorizontalMoving()
    {
        _moveDirection=_stopHorizontalMovingVector;
    }
}
