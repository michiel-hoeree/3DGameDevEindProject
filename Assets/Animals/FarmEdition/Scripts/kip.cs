using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kip : MonoBehaviour
{
    public float snelheid = 2.0f; // Snelheid van de beweging
    public float veranderRichtingInterval = 2.0f; // Interval om van richting te veranderen
    public float minAfstandTussenKippen = 1.0f; // Minimale afstand tussen kippen
    public Vector3 hoekpunt1 = new Vector3(-10f, 0f, -10f);
    public Vector3 hoekpunt2 = new Vector3(10f, 0f, 10f);
    public Vector3 hoekpunt3 = new Vector3(10f, 0f, -10f);
    public Vector3 hoekpunt4 = new Vector3(-10f, 0f, 10f);

    private void Start()
    {
        // Begin met een initiële positie binnen de rechthoek
        transform.position = new Vector3(Random.Range(hoekpunt1.x, hoekpunt2.x), 0f, Random.Range(hoekpunt1.z, hoekpunt2.z));
        VeranderRichting(); // Start met een initiële richtingsverandering
    }

    private void Update()
    {
        // Beweeg de kip alleen in het x-z vlak
        transform.Translate(Vector3.forward * snelheid * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, 0f, transform.position.z);

        // Controleer of de kip binnen de rechthoekige grenzen is en verander de richting indien nodig
        ControleerGrens();
        ControleerKippen();
    }

    private void VeranderRichting()
    {
        // Genereer een willekeurige rotatie binnen de opgegeven hoekpunten van de rechthoek
        float willekeurigeRotatieX = Random.Range(hoekpunt1.x, hoekpunt2.x);
        float willekeurigeRotatieZ = Random.Range(hoekpunt1.z, hoekpunt2.z);
        transform.rotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
    }

    private void ControleerGrens()
    {
        // Controleer of de kip binnen de rechthoekige grenzen is
        Vector3 huidigePositie = transform.position;
        huidigePositie.x = Mathf.Clamp(huidigePositie.x, Mathf.Min(hoekpunt1.x, hoekpunt2.x, hoekpunt3.x, hoekpunt4.x), Mathf.Max(hoekpunt1.x, hoekpunt2.x, hoekpunt3.x, hoekpunt4.x));
        huidigePositie.z = Mathf.Clamp(huidigePositie.z, Mathf.Min(hoekpunt1.z, hoekpunt2.z, hoekpunt3.z, hoekpunt4.z), Mathf.Max(hoekpunt1.z, hoekpunt2.z, hoekpunt3.z, hoekpunt4.z));
        transform.position = huidigePositie;

        // Controleer of de kip een grens heeft bereikt en verander de richting indien nodig
        if (huidigePositie.x == hoekpunt1.x || huidigePositie.x == hoekpunt2.x || huidigePositie.z == hoekpunt1.z || huidigePositie.z == hoekpunt3.z)
        {
            VeranderRichting();
        }
    }

    private void ControleerKippen()
    {
        // Vind alle kippen in de scène
        GameObject[] kippen = GameObject.FindGameObjectsWithTag("Chicken");

        // Loop door alle gevonden kippen
        foreach (GameObject kip in kippen)
        {
            // Controleer of de kip niet zichzelf is
            if (kip != gameObject)
            {
                // Bereken de afstand tussen de huidige kip en de andere kip
                float afstand = Vector3.Distance(transform.position, kip.transform.position);

                // Als de afstand kleiner is dan de minimaal toegestane afstand, verander de richting
                if (afstand < minAfstandTussenKippen)
                {
                    VeranderRichting();
                }
            }
        }
    }
}
