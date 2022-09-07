using UnityEngine;

public class LampostsSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _lampostGO;
    [SerializeField] private Vector3 _lampostBoundVector3;
    [SerializeField] private Vector3 _lampostSpawnVector3;
    private Rigidbody _lampostRB;

    private void Start()
    {
        _lampostRB = _lampostGO.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_lampostRB.position.z < _lampostBoundVector3.z)
            _lampostRB.MovePosition(_lampostSpawnVector3);
    }
}
