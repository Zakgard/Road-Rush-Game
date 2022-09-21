using UnityEngine;

public class CloseDiscleimer : MonoBehaviour
{
    [SerializeField] private GameObject _diskleimerScreen;

    public void OnCloseDiskleimerButtonClick()
    {       
        LevelLoad._lodingSceneOperator.allowSceneActivation = true;        
    }
}
