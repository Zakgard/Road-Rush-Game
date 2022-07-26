using UnityEngine;


public class MovePlayer : MonoBehaviour
{
    [Header("������ �����")]
    [SerializeField] private GameObject _player;

    [Header("�������� ��������")]
    [SerializeField] private float _speed=20;
    private void FixedUpdate()
    {
        _player.transform.Translate(new Vector3(0, 0, _speed * Time.deltaTime));
    }


}
