using UnityEngine;

public class DestructionEnemyesAfterCrossingBound : MonoBehaviour
{
    [SerializeField] private GameObject _enemyGO;
    private Rigidbody _enemyRigidbody;
    [SerializeField] private float _destructionBoundZOfEnemy;

    private void Start()
    {
        _enemyRigidbody=_enemyGO.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if(_enemyRigidbody.position.z< _destructionBoundZOfEnemy)
            Destroy(_enemyGO);
    }
}
