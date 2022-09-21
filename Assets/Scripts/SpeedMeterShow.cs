using UnityEngine;
using TMPro;

public class SpeedMeterShow : MonoBehaviour
{

    [SerializeField] private TMP_Text _speedMeterTExt;

    public static SpeedMeterShow Instance { get; private set;}

    private void Awake()
    {
        Instance = this;
    }
    public void ShowSpeed(float speed)
    {
        _speedMeterTExt.text = "Ваша скорость: " + speed*10;
    }
}
