using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Beweging : MonoBehaviour
{
    public GameObject panelToHide; // Sleep je paneel naar deze variabele in de Inspector.

    public Button goToSceneButton; // Sleep je knop (Button) naar deze variabele in de Inspector.
    public string targetSceneName = "start";

    public GameObject popupPanel; // Voeg hier je popup paneel toe vanuit de Unity Editor of instantieer het programmatisch.
    public Text popupText; // Voeg een tekstveld toe aan je popup paneel om de score te tonen.

    public Camera thirdPersonCamera;  // Voeg deze regel toe

    public SimpleSampleCharacterControl characterControl; // Referentie naar het script van je speler.

    public int score = 0;

    private void Start()
    {
        StartCoroutine(HidePanelAfterDelay(10f));

        characterControl = GetComponent<SimpleSampleCharacterControl>();

        Debug.Log("Start methode aangeroepen.");

        if (goToSceneButton != null)
        {
            // Voeg een luisteraar toe aan de knop om te reageren wanneer erop wordt geklikt.
            goToSceneButton.onClick.AddListener(GoToScene);
        }
    }

    IEnumerator HidePanelAfterDelay(float delay)
    {
        // Wacht voor het opgegeven aantal seconden.
        yield return new WaitForSeconds(delay);

        // Controleer of het paneel niet null is en verberg het als dat zo is.
        if (panelToHide != null)
        {
            panelToHide.SetActive(false);
        }
    }
    private void GoToScene()
    {
        SceneManager.LoadScene(targetSceneName);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter methode aangeroepen.");
        Debug.Log("Trigger geactiveerd met: " + other.gameObject.name);  // Controleer welk object de trigger activeert

        if (other.gameObject.CompareTag("Fiets"))
        {
            VerhoogScore();
            Debug.Log("Fiets geraakt! Score verhoogd naar: " + score);
            Destroy(other.gameObject); // Vernietig de fiets
        }
        else if (other.gameObject.CompareTag("Auto"))
        {
            VerlaagScore();
            Debug.Log("Auto geraakt! Score verlaagd naar: " + score);
            Destroy(other.gameObject); // Vernietig de auto
        }
        else if (other.gameObject.CompareTag("Bus"))
        {
            VerhoogScore();
            Debug.Log("Bus geraakt! Score Verhoogd naar: " + score);
            Destroy(other.gameObject); // Vernietig de auto
        }
        else if (other.gameObject.CompareTag("Tram"))
        {
            VerhoogScore();
            Debug.Log("Tram geraakt! Score Verhoogd naar: " + score);
            Destroy(other.gameObject); // Vernietig de auto
        }

        if (other.gameObject.CompareTag("Finish")) // Controleer of het je speler is die de trigger activeert
        {
            Debug.Log("werk nu eens mee");
            // Toon popup met score
            ShowPopup(score);
        }
    }

    public void VerhoogScore()
    {
        score += 1;
        Debug.Log("Je hebt een fiets geraakt! Score +1. Huidige score: " + score);
        characterControl.m_moveSpeed += 2; // Verhoog de snelheid met 1.0f.
        Debug.Log("Je hebt een punt gescoord! Nieuwe snelheid: " + characterControl.m_moveSpeed);
    }
    public void VerlaagScore()
    {
        score -= 1;
        Debug.Log("Je hebt een auto geraakt! Score -1. Huidige score: " + score);
        characterControl.m_moveSpeed = 5; // Zet de snelheid terug naar de oorspronkelijke waarde (of wat je als normaal beschouwt).
        Debug.Log("Je hebt een score verloren! Nieuwe snelheid: " + characterControl.m_moveSpeed);
    }

    private void ShowPopup(int score)
    {
        Debug.Log("show popup");
        if (popupPanel && popupText)
        {
            popupText.text = score.ToString();

            Debug.Log("Goed gedaan! Je score is: " + score.ToString());
            popupPanel.SetActive(true); // Toon het popup paneel

            // Wissel naar third-person camera
            thirdPersonCamera.enabled = true;
        }
    }


}