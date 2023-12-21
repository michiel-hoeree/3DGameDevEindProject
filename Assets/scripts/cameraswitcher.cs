using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class cameraswitcher : MonoBehaviour
{
    public Camera thirdPersonCamera;
    public Camera firstPersonCamera;
    public Text thirdPersonScoreText;  // Voor third-person camera
    public Text firstPersonScoreText;  // Voor first-person camera

    void Start()
    {
        EnableThirdPersonCamera();
    }

    void Update()
    {
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

        // Zet de scoretekst voor third-person camera op actief
        thirdPersonScoreText.enabled = true;

        // Verberg de scoretekst voor first-person camera
        firstPersonScoreText.enabled = false;
    }

    void EnableFirstPersonCamera()
    {
        thirdPersonCamera.enabled = false;
        firstPersonCamera.enabled = true;

        // Zet de scoretekst voor first-person camera op actief
        firstPersonScoreText.enabled = true;

        // Verberg de scoretekst voor third-person camera
        thirdPersonScoreText.enabled = false;
    }
}