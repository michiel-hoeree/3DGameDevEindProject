using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endButton : MonoBehaviour
{
    // Voeg een UI Button toe aan het eindcanvas en sleep het naar dit veld in de Unity Inspector
    public UnityEngine.UI.Button backButton;

    void Start()
    {
        // Voeg een luisteraar toe aan de knop om de functie TerugTeGaan aan te roepen
        if (backButton != null)
        {
            backButton.onClick.AddListener(TerugTeGaan);
        }
    }

    void TerugTeGaan()
    {
        // Voeg hier eventuele clean-up of andere logica toe voordat je naar een andere scene gaat

        // Laad de gewenste scene
        SceneManager.LoadScene("NaamVanDeAndereScene");
    }
}
