using UnityEngine;

public class PlayersCarSpeedIncrease : MonoBehaviour
{
    private float _carSpeed= CarSelectorActivate.carSpeed/10;    
    private void Start()
    {
       
        InvokeRepeating("SpeedIncrease", 0.0f, 10.0f);
    }

    private void Update()
    {       
        moveback.speed = _carSpeed;                
    }
    public void SpeedIncrease()
    {
        _carSpeed+=0.5f;
        SpeedMeterShow.Instance.ShowSpeed(_carSpeed*3f);
        EnemyCarsMovingForward.speedFromImcreasing = _carSpeed;
    }
}
