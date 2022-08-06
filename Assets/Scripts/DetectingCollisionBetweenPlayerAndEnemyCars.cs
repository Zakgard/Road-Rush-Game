using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectingCollisionBetweenPlayerAndEnemyCars : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"Collision with {collision.gameObject.name}");
        collision.gameObject.SetActive(false);
    }
}
