using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToTheMainMenu : MonoBehaviour
{
    public void OnLeaveButtonClick()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Start Menu", LoadSceneMode.Single);        
    }
}
