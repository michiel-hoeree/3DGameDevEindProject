using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bootcollision : MonoBehaviour
{
    public static int teller { get; set; } = 0;
    public Canvas eindcanvas;
    public AudioSource splash;

    void OnTriggerEnter(Collider other)
    {
        splash.Play();
        // Controleer of het object waarmee is gebotst het afval is
        if (other.CompareTag("afval"))
        {
            // Verwijder het afvalobject
            Destroy(other.gameObject);
            teller++;
            ControleerEinde();
        }
    }
    void ControleerEinde()
    {
        if (teller >= afvalmaker.aantalflessen)
        {
            eindcanvas.gameObject.SetActive(true);
            
        }
    }
}
