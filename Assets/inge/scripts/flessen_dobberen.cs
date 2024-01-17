using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flessen_dobberen : MonoBehaviour
{
    public float beweegSnelheid = 0.2f; // Snelheid van de beweging
    public float beweegAfstand = 1.0f; // Afstand die het object omhoog en omlaag beweegt
    public float starthoogte = -0.8f;
    
    // Update is called once per frame

    void Update()
    {
        // Bereken de nieuwe hoogte op basis van de sinus van de tijd
        float newY = (Mathf.Sin(Time.time * beweegSnelheid) * beweegAfstand) + starthoogte;
        
        // Pas de hoogte van het object aan
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
