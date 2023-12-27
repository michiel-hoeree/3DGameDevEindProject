using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kip : MonoBehaviour
{
    public float snelheid = 2.0f; // Snelheid van de beweging
    public float veranderRichtingInterval = 2.0f; // Interval om van richting te veranderen
    public Vector3 hoekpunt1 = new Vector3(-10f, 0f, -10f);
    public Vector3 hoekpunt2 = new Vector3(10f, 0f, 10f);
    public Vector3 hoekpunt3 = new Vector3(10f, 0f, -10f);
    public Vector3 hoekpunt4 = new Vector3(-10f, 0f, 10f);

    private float timer; // Timer om het interval bij te houden

    

    void Start()
    {
        VeranderRichting(); // Start met een initiële richtingsverandering
    }

    void Update()
    {
        // Beweeg de kip in de huidige richting (beperk beweging tot z en x as)
        transform.Translate(Vector3.forward * snelheid * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, 0f, transform.position.z);

        // Controleer of de kip binnen de rechthoekige grenzen is en corrigeer indien nodig
        ControleerGrens();

        // Tel de tijd op
        timer += Time.deltaTime;

        // Controleer of het tijd is om van richting te veranderen
        if (timer >= veranderRichtingInterval)
        {
            VeranderRichting();
        }
    }

    void VeranderRichting()
    {
        // Genereer een willekeurige rotatie binnen de opgegeven hoekpunten van de rechthoek
        float willekeurigeRotatieX = Random.Range(hoekpunt1.x, hoekpunt2.x);
        float willekeurigeRotatieZ = Random.Range(hoekpunt1.z, hoekpunt2.z);
        transform.rotation = Quaternion.Euler(willekeurigeRotatieX, 0f, willekeurigeRotatieZ);

        // Reset de timer
        timer = 0f;
    }

    void ControleerGrens()
    {
        // Controleer of de kip binnen de rechthoekige grenzen is
        Vector3 huidigePositie = transform.position;
        huidigePositie.x = Mathf.Clamp(huidigePositie.x, Mathf.Min(hoekpunt1.x, hoekpunt2.x, hoekpunt3.x, hoekpunt4.x), Mathf.Max(hoekpunt1.x, hoekpunt2.x, hoekpunt3.x, hoekpunt4.x));
        huidigePositie.z = Mathf.Clamp(huidigePositie.z, Mathf.Min(hoekpunt1.z, hoekpunt2.z, hoekpunt3.z, hoekpunt4.z), Mathf.Max(hoekpunt1.z, hoekpunt2.z, hoekpunt3.z, hoekpunt4.z));
        transform.position = huidigePositie;
    }
}
