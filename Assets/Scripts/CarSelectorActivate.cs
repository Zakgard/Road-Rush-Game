using UnityEngine;

public class CarSelectorActivate : MonoBehaviour
{
    [Header("Меню выбора машин")]
    [SerializeField] private GameObject rectTransform;

    public static int carINdex;

    [Header("Пункты меню, которые станут неактивными", order = 5)]
    [SerializeField] private GameObject _startButton;
    [SerializeField] private GameObject _settingsButton;
    [SerializeField] private GameObject _changeCarButton;
    [SerializeField] private GameObject _creditsButton;
    [SerializeField] private GameObject _exitButton;

    [SerializeField] private 
    void OnButtonClick()
    {
        rectTransform.SetActive(true);
        _startButton.SetActive(false);
        _settingsButton.SetActive(false);
        _creditsButton.SetActive(false);
        _exitButton.SetActive(false);
        _changeCarButton.SetActive(false);
    }

    public void OnCarSelect(int index)
    {
        carINdex = index;
        rectTransform.SetActive(false);
        _startButton.SetActive(true);
        _settingsButton.SetActive(true);
        _creditsButton.SetActive(true);
        _exitButton.SetActive(true);
        _changeCarButton.SetActive(true);
        Debug.LogFormat("{0} car selected!", index);
    }

    public void SetCarIndex(int index)
    {
        
    }
}
