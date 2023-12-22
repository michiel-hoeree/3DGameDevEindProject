using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Beweging : MonoBehaviour
{
    private ScoreManager scoreManager;
    public int score = 0;

    private void Start()
    {
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
    }

    public void VerhoogScore()
    {
        score += 1;
        Debug.Log("Je hebt een fiets geraakt! Score +10. Huidige score: " + score);
    }
    public void VerlaagScore()
    {
        score -= 1;
        Debug.Log("Je hebt een auto geraakt! Score -5. Huidige score: " + score);
    }
}