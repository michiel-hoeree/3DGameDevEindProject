using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Sleep hier je TMP Text-object naartoe in de Unity Inspector
    public GameObject huidigCanvas;
    public GameObject eindCanvas;

    float timerDurationInMinutes = 1f;  // Stel de gewenste duur in op 1 minuut
    float timer;

    bool isTimeOver = false;

    void Update()
    {
        if (!isTimeOver)
        {
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                StopSpel();
            }

            UpdateTimerText(); // Voeg deze lijn toe om de timer-text bij te werken
        }
    }

    void Start()
    {
        timer = timerDurationInMinutes * 60f;  // Zet de timer om naar seconden
        UpdateTimerText(); // Voeg deze lijn toe om de timer-text bij te werken bij het starten
    }

    void UpdateTimerText()
    {
        if (!isTimeOver)
        {
            // Formatteer de timer als MM:SS (minuten en seconden)
            int minuten = Mathf.FloorToInt(timer / 60f);
            int seconden = Mathf.FloorToInt(timer % 60f);

            // Update de TMP Text met de geformatteerde timer
            timerText.text = string.Format("{0:00}:{1:00}", minuten, seconden);

        }
        else
        {
            // Als de tijd voorbij is, update de TMP Text naar "Time Over"
            timerText.text = "Time Over";

            // Schakel het huidige canvas uit en het eindcanvas in
            huidigCanvas.SetActive(false);
            eindCanvas.SetActive(true);
        }
    }

    void StopSpel()
    {
        isTimeOver = true; // Zet de tijd over status aan
        Time.timeScale = 0f;  // Zet het spel op pauze

        // Voeg hier code toe om het spel te stoppen, de pop-up weer te geven, etc.
        Debug.Log("Het spel is gestopt!");
    }
}
