using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovePlayer : MonoBehaviour
{
    [Header("������ �����")]
    [SerializeField] private GameObject _player;

    [Header("�������� ��������")]
    [SerializeField] private float _speed=20;
    void Update()
    {
        _player.transform.Translate(new Vector3(0, 0, _speed * Time.deltaTime));
    }


}
