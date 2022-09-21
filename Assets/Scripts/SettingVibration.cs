using UnityEngine;
using UnityEngine.UI;

public class SettingVibration : MonoBehaviour
{
    [SerializeField] private Toggle _vibrationToggle;
    public static bool isVibrationTurnedOn=true;

    public void OnToggleValueChange()
    {
        isVibrationTurnedOn=_vibrationToggle.isOn;
    }

    
}
