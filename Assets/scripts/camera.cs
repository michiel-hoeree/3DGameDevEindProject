using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Camera mainCamera;
    public Camera kippenhokCamera;
    public Canvas mainCanvas;

    void Start()
    {
        // Zet de juiste camera en canvas aan bij het starten
        EnableMainCamera();
        EnableMainCanvas();
    }

    void Update()
    {
        // Voeg hier je schakellogica toe, bijvoorbeeld op basis van een toetsindruk
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCamera();
        }
    }

    void SwitchCamera()
    {
        // Schakel tussen de camera's en canvas
        if (mainCamera.enabled)
        {
            EnableKippenhokCamera();
            DisableMainCanvas();
        }
        else
        {
            EnableMainCamera();
            EnableMainCanvas();
        }
    }

    void EnableMainCamera()
    {
        mainCamera.enabled = true;
        kippenhokCamera.enabled = false;
    }

    void EnableKippenhokCamera()
    {
        mainCamera.enabled = false;
        kippenhokCamera.enabled = true;
    }

    void EnableMainCanvas()
    {
        mainCanvas.enabled = true;
    }

    void DisableMainCanvas()
    {
        mainCanvas.enabled = false;
    }
}
