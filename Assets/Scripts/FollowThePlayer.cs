using UnityEngine;

 class FollowThePlayer : MonoBehaviour
{ 
    [SerializeField] private GameObject _camera;
    private GameObject _player;

    [SerializeField] private float _camersYPosition;

    [SerializeField] private Vector3 _offset = new Vector3(0, 6, -10);
    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
    
    private void LateUpdate()
    {
        _camera.transform.position=_player.transform.position+_offset;
    }
}
