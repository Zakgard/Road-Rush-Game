using UnityEngine;

public class HealingAfterCollisionWithTool : MonoBehaviour
{
    public GameOverBecauseOfLostHealthPoints _gameOverBecauseOfLostHealthPoints;
    private float _hp;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RepairTool")
        {            
            _hp= _gameOverBecauseOfLostHealthPoints.playersHealth += 1;
            PlayRepairSound.Instance.PlayRepairSoundAfterCollision();
            Destroy(collision.gameObject);            
            HealthPointsDisplay.Instance.ShowHPOnPanel(_hp);
        }
        
    }

    
}
