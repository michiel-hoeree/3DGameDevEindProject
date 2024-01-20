using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauze : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas pauzeScherm;
    public GameObject boot;
    bool isPauze = false;
    void Start()
    {
        stopPauze();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
        if(isPauze == false)
            {
                startPauze();
            }
        else
            {
                stopPauze();
            }
        }
        
    }
   void startPauze()
    {
        pauzeScherm.gameObject.SetActive(true);
        boot.SetActive(false);
        isPauze = true;
    }
    void stopPauze()
    {
        pauzeScherm.gameObject.SetActive(false);
        boot.SetActive(true);
        isPauze = false;
    }
    
}
