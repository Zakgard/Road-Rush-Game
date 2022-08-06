using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToTheMainMenu : MonoBehaviour
{
    public void OnLeaveButtonClick()
    {
        SceneManager.LoadScene("Start Menu", LoadSceneMode.Single);
    }
}
