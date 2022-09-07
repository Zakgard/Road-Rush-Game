using UnityEngine;

public class GameContinuationAfterPause : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanelGO;
    [SerializeField] private GameObject _pauseButtonGO;
    [SerializeField] private GameObject _controlsButtons;
    public void OnContinueButtonClick()
    {
        _pausePanelGO.SetActive(false);
        _pauseButtonGO.SetActive(true);
        _controlsButtons.SetActive(true);
        Time.timeScale = 1.0f;
    }
}
