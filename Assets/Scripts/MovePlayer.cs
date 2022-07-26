using UnityEngine;


public class MovePlayer : MonoBehaviour
{
    [Header("Объект игрок")]
    [SerializeField] private GameObject _player;

    [Header("Скорость движения")]
    [SerializeField] private float _speed=20;
    private void FixedUpdate()
    {
        _player.transform.Translate(new Vector3(0, 0, _speed * Time.deltaTime));
    }


}
