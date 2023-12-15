using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraswitcher : MonoBehaviour
{
    public Camera thirdPersonCamera;
    public Camera firstPersonCamera;

    void Start()
    {
        // Zorg ervoor dat de third-person camera is ingeschakeld en de first-person camera is uitgeschakeld bij het starten.
        EnableThirdPersonCamera();
    }

    void Update()
    {
        // Schakel tussen third-person en first-person camera bij het indrukken van de "C"-toets.
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (thirdPersonCamera.enabled)
                EnableFirstPersonCamera();
            else
                EnableThirdPersonCamera();
        }
    }

    void EnableThirdPersonCamera()
    {
        thirdPersonCamera.enabled = true;
        firstPersonCamera.enabled = false;
    }

    void EnableFirstPersonCamera()
    {
        thirdPersonCamera.enabled = false;
        firstPersonCamera.enabled = true;
    }
}
