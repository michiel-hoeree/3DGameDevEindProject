using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class eiOppakken : MonoBehaviour, IPointerClickHandler
{
    public static int aantalEierenGlobaal = 0;
    public TMP_Text eierenTellerText; // Verwijzing naar het TMP tekstobject op het canvas
    public TMP_Text eindeText;

    void Start()
    {
        UpdateUI();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Ei geklikt!");
        VerwijderEi(); // Eerst het ei verwijderen
        VerzamelEi();  // Dan het aantal eieren verhogen
    }

    void VerzamelEi()
    {
        aantalEierenGlobaal++;
        Debug.Log(aantalEierenGlobaal);
        UpdateUI();
    }

    void VerwijderEi()
    {
        // Verwijder het GameObject (het ei) van de scène
        Destroy(gameObject);
    }

    void UpdateUI()
    {
        if (eierenTellerText != null)
        {
            eierenTellerText.text = "Eieren: " + aantalEierenGlobaal;
            eindeText.text = "Totaal aantal verzamelde eieren: " + aantalEierenGlobaal;
        }
    }
}

