using UnityEngine;

public class ZaborSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _fance;
    [SerializeField] private Vector3 _spawPosition;
    [SerializeField] private Vector3 _boundCoordinates;
      

    private void Update()
    {
        if (_fance.transform.position.z < _boundCoordinates.z)
        {
              _fance.transform.Translate(_spawPosition);
              
        }
           
    }
}
