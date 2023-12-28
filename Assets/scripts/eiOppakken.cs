using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class eiOppakken : MonoBehaviour, IPointerClickHandler
{
    private int aantalEieren = 0;
    public TMP_Text eierenTellerText; // Verwijzing naar het TMP tekstobject op het canvas

    void Start()
    {
        UpdateUI();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        VerzamelEi();
        VerwijderEi();
    }

    void VerzamelEi()
    {
        aantalEieren++;
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
            eierenTellerText.text = "Eieren: " + aantalEieren;
        }
    }
}

