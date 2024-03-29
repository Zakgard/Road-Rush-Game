using UnityEngine;

public class GameOverBecauseOfLostHealthPoints : MonoBehaviour
{
    public float playersHealth;
    [SerializeField] private GameObject _playerGO;

    private void Update()
    {
        HealthPointsDisplay.Instance.ShowHPOnPanel(playersHealth);
        if (playersHealth <= 0)
        {
            Debug.Log("Game Over!");
            PlayLevel1Sounds.Instance.PlayGameOverSound();
            Destroy(_playerGO);
            HealthPointsDisplay.Instance.OpenTheGameOverPanel();
        }                    
    }
}
