using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasSwitch : MonoBehaviour
{
    public GameObject startCanvas;
    public GameObject gameCanvas;

    void Start()
    {
        // Activeer het startCanvas bij het begin van het spel
        startCanvas.SetActive(true);

        // Start een coroutine om na 20 seconden over te schakelen naar het gameCanvas
        StartCoroutine(SwitchCanvasAfterDelay());
    }

    IEnumerator SwitchCanvasAfterDelay()
    {
        yield return new WaitForSeconds(20f);

        // Deactiveer het startCanvas
        startCanvas.SetActive(false);

        // Activeer het gameCanvas
        gameCanvas.SetActive(true);
    }
}
