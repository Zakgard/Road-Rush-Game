using UnityEngine;

public class DetectingCollisionBetweenPlayerAndEnemyCars : MonoBehaviour
{
    public GameOverBecauseOfLostHealthPoints gameOverBecauseOfLostHealthPoints;
    private float _hp;
   
    private void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.tag == "Enemy")
        {
            _hp = gameOverBecauseOfLostHealthPoints.playersHealth -= 1;
            Destroy(collision.gameObject);           
            HealthPointsDisplay.Instance.ShowHPOnPanel(_hp);
            if(SettingVibration.isVibrationTurnedOn==true)
                Handheld.Vibrate();
        }
               
    }

}
