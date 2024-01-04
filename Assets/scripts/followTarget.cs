using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followTarget : MonoBehaviour
{
    public Transform targetObject; // The object whose position you want to match



    void Update()
    {
        transform.position = targetObject.position;
    }
}
