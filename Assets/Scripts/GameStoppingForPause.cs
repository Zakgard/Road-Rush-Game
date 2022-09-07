using UnityEngine;

public class GameStoppingForPause : MonoBehaviour
{    
    [SerializeField] private GameObject _pauseButtonGO;
    [SerializeField] private GameObject _pausePanelGO;
    [SerializeField] private GameObject _controlsButtons;
    public void OnPauseButtonClick()
    {
        Time.timeScale = 0.0f;
        _pauseButtonGO.SetActive(false);
        _controlsButtons.SetActive(false);
        _pausePanelGO.SetActive(true);
    }
}
