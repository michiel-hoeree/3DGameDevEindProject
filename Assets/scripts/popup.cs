using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup : MonoBehaviour
{
    public GameObject startSpawning;
    private void OnGUI()
    {
        string text = "Controls:\n";
        text += "- Arrow keys to move around\n";
        text += "- Press 'E' to interact\n";
        text += "Goal:\n";
        text += "Je moet 30 groenten verzamelen.\n";
        text += "Als de groenten opgegroeid zijn kan je ze verzamelen\n";
        text += "Maar opgelet: als een spin tot bij je groeten komt eet die ze allemaal op\n";
        text += "Als dit gebeurd moet je wachten todat ze zijn terug gegroeid";


        GUI.Box(new Rect(25, 25, 400, 100), text);
        if (GUI.Button(new Rect(10, 120, 150, 40), "start"))
        {
            startSpawning.SetActive(false);
            enabled = false;

        }
    }

}
