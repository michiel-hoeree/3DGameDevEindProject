using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class VoedselSpeler : MonoBehaviour
{
    public TMP_Text voedselTellerText;
    public static VoedselSpeler instance;

    private int voedselTeller = 0;
    public int voedselInVoederbak = 0;

    void Start()
    {
        UpdateVoedselTellerText();
        instance = this;
    }

    void UpdateVoedselTellerText()
    {
        voedselTellerText.text = "Voedsel: " + voedselTeller;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Voedsel"))
        {
            // Het voedsel is geraakt door de speler
            voedselTeller++;
            UpdateVoedselTellerText();
            Destroy(other.gameObject); // Verwijder het voedselobject
        }
        else if (other.CompareTag("Voederbak"))
        {
            // De voederbak is geraakt door de speler
            voedselInVoederbak += voedselTeller;
            voedselTeller = 0;
            UpdateVoedselTellerText();
        }
    }

    public int GetVoedselTeller()
    {
        return voedselInVoederbak;
    }
}
