using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;  // Referentie naar de tekstcomponent
    private Beweging bewegingScript;  // Referentie naar het Beweging script

    private void Start()
    {
        // Vind de tekstcomponent
        scoreText = GetComponent<Text>();

        // Vind het Beweging script
        bewegingScript = GameObject.FindObjectOfType<Beweging>();
    }

    private void Update()
    {
        // Update de score tekst bij elke frame-update
        UpdateScoreDisplay();
    }

    // Methode om de score tekst bij te werken
    private void UpdateScoreDisplay()
    {
        if (scoreText && bewegingScript)
        {
            scoreText.text = "Score: " + bewegingScript.score.ToString();
        }
        else
        {
            Debug.LogWarning("Tekstcomponent of Beweging script niet ingesteld!");
        }
    }
}