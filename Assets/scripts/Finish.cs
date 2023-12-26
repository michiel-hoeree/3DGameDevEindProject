using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public GameObject popupPanel; // Voeg hier je popup paneel toe vanuit de Unity Editor of instantieer het programmatisch.
    public Text popupText; // Voeg een tekstveld toe aan je popup paneel om de score te tonen.

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("dit werkt");

        if (other.gameObject.CompareTag("Player")) // Controleer of het je speler is die de trigger activeert
        {
            Beweging bewegingScript = other.gameObject.GetComponent<Beweging>();
            Debug.Log("werk nu eens mee");
                // Toon popup met score
            ShowPopup(bewegingScript.score);
        }
    }

    private void ShowPopup(int score)
    {
        Debug.Log("show popup");
        if (popupPanel && popupText)
        {
            popupText.text = "Goed gedaan! Je score is: " + score.ToString();
            Debug.Log("Goed gedaan! Je score is: " + score.ToString());
            popupPanel.SetActive(true); // Toon het popup paneel
        }
    }

    // Voeg een methode toe om het popup paneel te verbergen indien nodig
    public void HidePopup()
    {
        if (popupPanel)
        {
            popupPanel.SetActive(false); // Verberg het popup paneel
        }
    }
}