using UnityEngine;
using UnityEngine.UI;

public class SettingVibration : MonoBehaviour
{
    [SerializeField] private Toggle _vibrationToggle;
    public bool isVibrationTurnedOn;

    public void OnToggleValueChange()
    {
        isVibrationTurnedOn=_vibrationToggle.isOn;
    }

    
}
