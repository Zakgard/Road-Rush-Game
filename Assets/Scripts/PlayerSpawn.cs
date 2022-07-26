using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{   
    [SerializeField]  private GameObject[] _playerCarArray=new GameObject[5];

    private int _playerCarIndex= CarSelectorActivate.carINdex;

    public static GameObject player;

    private void Awake()
    {
       player= _playerCarArray[_playerCarIndex];
       Instantiate(_playerCarArray[_playerCarIndex], new Vector3(0,0, -210), Quaternion.identity);
    }
    
}
