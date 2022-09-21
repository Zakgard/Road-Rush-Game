using UnityEngine;
using TMPro;

public class ScoringPoints : MonoBehaviour
{
    [SerializeField] private TMP_Text _scorePointsText;
    [SerializeField] private float _scorePoints=0.0f;
    private float _scoreBuster;

    private void Start()
    {
        InvokeRepeating("ScoreIncreasing", 0.0f, 0.1f);
        InvokeRepeating("ScroBusterUP", 0.0f, 10.0f);
    }
    private void Update()
    {
        _scorePointsText.text = "Очки: " + _scorePoints;
        _scoreBuster = moveback.speed*10;
    }

    private void ScoreIncreasing()
    {
        _scorePoints += _scoreBuster;
    }

    private void ScroBusterUP()
    {
        _scoreBuster += 1;
    }
}
