using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bootcollision : MonoBehaviour
{
    public int teller = 0;
    void OnTriggerEnter(Collider other)
    {
        // Controleer of het object waarmee is gebotst het afval is
        if (other.CompareTag("afval"))
        {
            // Verwijder het afvalobject
            Destroy(other.gameObject);
            teller++;
        }
    }
}
