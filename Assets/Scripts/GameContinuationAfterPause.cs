using UnityEngine;

public class GameContinuationAfterPause : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanelGO;
    [SerializeField] private GameObject _pauseButtonGO;
    public void OnContinueButtonClick()
    {
        _pausePanelGO.SetActive(false);
        _pauseButtonGO.SetActive(true);
        Time.timeScale = 1.0f;
    }
}
