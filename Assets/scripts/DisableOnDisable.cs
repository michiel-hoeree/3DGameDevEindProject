/*using System.Collections;
using System.Collections.Generic;*/
using UnityEngine;

public class DisableOnDisable : MonoBehaviour
{
    public GameObject objectToDisable;

    void OnDisable()
    {
        if (objectToDisable != null && objectToDisable.activeSelf)
        {
            objectToDisable.SetActive(false);
        }
    }
}
