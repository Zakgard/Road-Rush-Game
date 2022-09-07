using UnityEngine;

public class OpeningSettings : MonoBehaviour
{
    [SerializeField] private GameObject _settingsPanelGO;
    [SerializeField] private GameObject _mainMebuUIElements;

    public void OnSettingsButtonClick()
    {
        _mainMebuUIElements.SetActive(false);
        _settingsPanelGO.SetActive(true);
    }
}
