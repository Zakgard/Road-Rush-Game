using UnityEngine;

public class TurnAroundCarsWithRoadInMenu : MonoBehaviour
{
    [SerializeField] private GameObject _carsAndRoadGO;
    [SerializeField] private float _turningSpeed;

    private void Update()
    {
        transform.Rotate(0, _turningSpeed * Time.deltaTime, 0, Space.World);
    }
}
