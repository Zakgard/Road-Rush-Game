using UnityEngine;
using TMPro;

public class ScoringPoints : MonoBehaviour
{
    [SerializeField] private TMP_Text _scorePointsText;
    [SerializeField] private float _scorePoints=0.0f;

    private void Start()
    {
        InvokeRepeating("ScoreIncreasing", 0.0f, 0.1f);
    }
    private void Update()
    {
        _scorePointsText.text = "Score: " + _scorePoints;
    }

    private void ScoreIncreasing()
    {
        _scorePoints += 1;
    }
}
