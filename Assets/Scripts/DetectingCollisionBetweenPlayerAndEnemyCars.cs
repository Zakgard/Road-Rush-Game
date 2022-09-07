using UnityEngine;

public class DetectingCollisionBetweenPlayerAndEnemyCars : MonoBehaviour
{
    public GameOverBecauseOfLostHealthPoints gameOverBecauseOfLostHealthPoints;
    private float _hp;
   
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision with {collision.gameObject.name}");
        _hp=gameOverBecauseOfLostHealthPoints.playersHealth -= 1;        
        Destroy(collision.gameObject);
        Handheld.Vibrate();
        HealthPointsDisplay.Instance.ShowHPOnPanel(_hp);
    }
}
