using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoedselSpawner : MonoBehaviour
{
    public GameObject bananaPrefab;
    public GameObject cheesePrefab;
    public GameObject cherryPrefab;
    public GameObject hamburgerPrefab;
    public GameObject hotdogPrefab;
    public GameObject olivePrefab;
    public GameObject watermelonPrefab;

    public int aantalVoedselItems = 10;
    public Vector3 hoekpunt1 = new Vector3(-10f, 0f, -10f);
    public Vector3 hoekpunt2 = new Vector3(10f, 0f, 10f);
    public Vector3 hoekpunt3 = new Vector3(10f, 0f, -10f);
    public Vector3 hoekpunt4 = new Vector3(-10f, 0f, 10f);

    void Start()
    {
        PlaatsVoedsel();
    }

    void PlaatsVoedsel()
    {
        for (int i = 0; i < aantalVoedselItems; i++)
        {
            // Kies een willekeurige positie binnen het opgegeven spawngebied
            Vector3 spawnPositie = new Vector3(
                Random.Range(Mathf.Min(hoekpunt1.x, hoekpunt2.x, hoekpunt3.x, hoekpunt4.x), Mathf.Max(hoekpunt1.x, hoekpunt2.x, hoekpunt3.x, hoekpunt4.x)),
                0.5f,
                Random.Range(Mathf.Min(hoekpunt1.z, hoekpunt2.z, hoekpunt3.z, hoekpunt4.z), Mathf.Max(hoekpunt1.z, hoekpunt2.z, hoekpunt3.z, hoekpunt4.z))
            );

            // Kies een willekeurig voedselobject
            GameObject voedselPrefab = KiesWillekeurigVoedselPrefab();

            // Maak het voedselobject op de gekozen positie
            Instantiate(voedselPrefab, spawnPositie, Quaternion.identity);
        }
    }

    GameObject KiesWillekeurigVoedselPrefab()
    {
        // Lijst van beschikbare voedselobjecten
        GameObject[] voedselPrefabs = {
            bananaPrefab,
            cheesePrefab,
            cherryPrefab,
            hamburgerPrefab,
            hotdogPrefab,
            olivePrefab,
            watermelonPrefab
        };

        // Kies willekeurig een voedselobject uit de lijst
        int willekeurigeIndex = Random.Range(0, voedselPrefabs.Length);
        return voedselPrefabs[willekeurigeIndex];
    }
}
