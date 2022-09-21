using UnityEngine;
using TMPro;

public class HealthPointsDisplay : MonoBehaviour
{    
    [SerializeField] private  TMP_Text _healthPointDisplay;
    [SerializeField] private GameObject _gameOverPanelGO;
    [SerializeField] private GameObject _pauseButton;
    [SerializeField] private GameObject _controlButtons;
    [SerializeField] private TMP_Text _gameOVerText;
    public static HealthPointsDisplay Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }
    public void ShowHPOnPanel(float hp)
    {
        _healthPointDisplay.text = "Ваши ОЗ: " + hp;
    }

    public void OpenTheGameOverPanel()
    {
        _gameOverPanelGO.SetActive(true);
        _gameOVerText.text = "Вы проиграли!";
        _pauseButton.SetActive(false);
        _controlButtons.SetActive(false);
        Time.timeScale = 0.0f;
    }

}
