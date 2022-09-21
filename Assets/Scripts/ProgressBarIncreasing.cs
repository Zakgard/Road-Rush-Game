using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProgressBarIncreasing : MonoBehaviour
{
    [SerializeField] private Image _progressBarImage;
    [SerializeField] private TMP_Text _progressBarText;
    [SerializeField] private GameObject _continueButton;
    private float _progressBarValue=0;

    private void Start()
    {
        InvokeRepeating("IncreaseProgressBarValue", 0.0f, 0.5f);
    }

    private void Update()
    {
        _progressBarImage.fillAmount = _progressBarValue/100;        
        _progressBarText.text = $"Загрузка: {_progressBarValue} %";
        if (_progressBarValue >= 100.0f)
        {
            _progressBarValue = 100.0f;
            CancelInvoke();
            _continueButton.SetActive(true);
        }

            
    }

    private void IncreaseProgressBarValue() => _progressBarValue += Random.Range(10,30);
}
