using UnityEngine;

public class ClosingAuthorsText : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenuUIElementsGO;
    [SerializeField] private GameObject _creditsUIElementsGO;

    public void OnCloseAuthorsTextButtonClick()
    {
        _creditsUIElementsGO.SetActive(false);
        _mainMenuUIElementsGO.SetActive(true);
    }
}
