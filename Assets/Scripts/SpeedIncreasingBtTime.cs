using UnityEngine;

public class SpeedIncreasingByTime : MonoBehaviour
{
    public static Vector3 movingVectorOfEnemiesAndRoad=new Vector3(0, 0, -1f);

    private void Start()
    {
        InvokeRepeating("ChangingMovingVectorOfEnemiesAndRoad", 10f, 10f);
    }
    private void ChangingMovingVectorOfEnemiesAndRoad()
    {
        movingVectorOfEnemiesAndRoad.z-=0.1f;
    }
}
