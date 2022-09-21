using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    [SerializeField] private GameObject _loadingScreen;
    public static AsyncOperation _lodingSceneOperator;
    
    public void OnButtonClick()
    {
        _loadingScreen.SetActive(true);
        _lodingSceneOperator= SceneManager.LoadSceneAsync("Level1", LoadSceneMode.Single);
        _lodingSceneOperator.allowSceneActivation = false;
        Time.timeScale = 1.0F;
    }
 
}
