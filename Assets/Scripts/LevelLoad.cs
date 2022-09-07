using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{    
    public void OnButtonClick()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        Time.timeScale = 1.0F;
    }
 
}
