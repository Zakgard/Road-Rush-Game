using UnityEngine;

 class FollowThePlayer : MonoBehaviour
{ 
    [SerializeField] private GameObject _camera;
    private GameObject _player;
    private Rigidbody _playerRigidbody;
    [SerializeField] private float _camersYPosition;

    [SerializeField] private Vector3 _offset = new Vector3(0, 6, -10);
    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _playerRigidbody=_player.GetComponent<Rigidbody>();
    }
    
    private void LateUpdate()
    {
        _camera.transform.position= _playerRigidbody.position+_offset;
    }
}
