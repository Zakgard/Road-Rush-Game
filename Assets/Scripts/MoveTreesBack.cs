using UnityEngine;

public class MoveTreesBack : MonoBehaviour
{
    [SerializeField] private GameObject _treeGO;
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _movingDirection;
    [SerializeField] private float _speedDivision;

    private void Update()
    {
        transform.Translate(_movingDirection*_speed*Time.deltaTime*moveback.speed/_speedDivision);
    }

}
