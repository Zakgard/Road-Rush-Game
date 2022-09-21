using UnityEngine;

public class EnemyCarsMovingForward : MonoBehaviour
{
    [SerializeField] private GameObject _enemyCarGameObject;
    private Rigidbody _enemyCarRB;
    public static float speedFromImcreasing;
    private Vector3 _enemyMovingDirection = new Vector3(0, 0, -1f);
    private void Start()
    {
        _enemyCarRB = _enemyCarGameObject.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        
        _enemyCarRB.MovePosition(_enemyCarRB.position+ new Vector3(0,0,_enemyMovingDirection.z*speedFromImcreasing));
    }
}
