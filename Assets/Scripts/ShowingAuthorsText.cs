using UnityEngine;

public class ShowingAuthorsText : MonoBehaviour
{
    [SerializeField] private GameObject _authorsTextGO;
    [SerializeField] private GameObject _mainMenuButtons;

    public void OnCreditsButtonClick()
    {
        _mainMenuButtons.SetActive(false);
        _authorsTextGO.SetActive(true);
    }
}
