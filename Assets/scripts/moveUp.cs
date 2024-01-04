using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetBeets : MonoBehaviour
{
    public float moveDistance = 10f;
    public GameObject gameStarter;
    void Update()
    {
        if (!gameStarter.activeInHierarchy)
        {
            MoveUp();
        }
    }

    void MoveUp()
    {
        Vector3 newPosition = transform.position + Vector3.up * moveDistance;

        transform.position = newPosition;
    }
}
