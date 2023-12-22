using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Beweging : MonoBehaviour
{
    public SimpleSampleCharacterControl characterControl; // Referentie naar het script van je speler.


    private ScoreManager scoreManager;
    public int score = 0;

    private void Start()
    {
        characterControl = GetComponent<SimpleSampleCharacterControl>();

        Debug.Log("Start methode aangeroepen.");
        scoreManager = GameObject.Find("GameManager").GetComponent<ScoreManager>();
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
    }

    public void VerhoogScore()
    {
        score += 1;
        Debug.Log("Je hebt een fiets geraakt! Score +10. Huidige score: " + score);
        characterControl.m_moveSpeed += 1.0f; // Verhoog de snelheid met 1.0f, pas dit aan op basis van wat je wilt.
        Debug.Log("Je hebt een punt gescoord! Nieuwe snelheid: " + characterControl.m_moveSpeed);

    }
    public void VerlaagScore()
    {
        score -= 1;
        Debug.Log("Je hebt een auto geraakt! Score -5. Huidige score: " + score);
        characterControl.m_moveSpeed = 2.0f; // Zet de snelheid terug naar de oorspronkelijke waarde (of wat je als normaal beschouwt).
        Debug.Log("Je hebt een score verloren! Nieuwe snelheid: " + characterControl.m_moveSpeed);
    }
}