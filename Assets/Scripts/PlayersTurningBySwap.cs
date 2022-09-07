using UnityEngine;

public class PlayersTurningBySwap : MonoBehaviour
{
    [SerializeField] private GameObject _playersGO;
    [SerializeField] private Rigidbody _playersRB;
    [SerializeField] private Vector2 _playersStartPosition;
    [SerializeField] private Vector2 _playersMovingDirection;
    [SerializeField] private bool _isdirectionChosen;



    private void Start()
    {
        _playersRB=_playersGO.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        if (Input.touchCount == 1)
        {
            Touch usersTouch=Input.GetTouch(0);

            switch (usersTouch.phase)
            {
                case TouchPhase.Began:
                    _playersStartPosition=usersTouch.position;
                    _isdirectionChosen=false;
                    break;
                case TouchPhase.Moved:
                    _playersMovingDirection = usersTouch.position - _playersStartPosition;
                    break;
                case TouchPhase.Ended:
                    _isdirectionChosen=true;
                    break;
            }
        }
        if (_isdirectionChosen)
        {
           // _playersRB.MovePosition
        }
    }
}
