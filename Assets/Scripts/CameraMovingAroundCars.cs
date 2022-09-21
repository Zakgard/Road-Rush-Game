using UnityEngine;

public class CameraMovingAroundCars : MonoBehaviour
{
    [SerializeField] private GameObject _cameraGO;
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }

}
