using UnityEngine;

public class BootBeweging : MonoBehaviour
{
    public float snelheid = 5f; // Snelheid van de boot
    public float draaisnelheid = 100f; // Snelheid waarmee de boot draait

    void Update()
    {
        Draai(); // Functie om links en rechts te draaien
        Beweeg(); // Functie om vooruit en achteruit te bewegen
    }

   void Draai()
    {
        float linksRechtsInput = Input.GetAxis("Horizontal"); // Input voor links en rechts draaien
       float draaiingLinksRechts = linksRechtsInput * draaisnelheid * Time.deltaTime;
        transform.Rotate(Vector3.up * draaiingLinksRechts);
    }

    void Beweeg()
    {
        float voorAchterInput = Input.GetAxis("Vertical"); // Input voor vooruit en achteruit bewegen

        if (voorAchterInput != 0)
        {
            float bewegingVooruitAchteruit = voorAchterInput * snelheid * Time.deltaTime;
            transform.Translate(Vector3.forward * bewegingVooruitAchteruit);
        }
    }
}
