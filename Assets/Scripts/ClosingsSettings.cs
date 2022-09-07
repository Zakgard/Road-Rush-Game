using UnityEngine;

public class ClosingsSettings : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenuUIElements;
    [SerializeField] private GameObject _settingsPanelGO;

    public void OnClosingSettingButtonClick()
    {
        _settingsPanelGO.SetActive(false);
        _mainMenuUIElements.SetActive(true);
    }
}
