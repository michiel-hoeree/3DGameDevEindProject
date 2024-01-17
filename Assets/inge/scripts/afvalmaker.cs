using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class afvalmaker : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    //zee is 200 op 200
    public float grootsteXY = 10;
    public float kleinsteXY = -10;
    float randomRotation;

    public float hoogte = -0.8f;
    public int aantalFlessenPerSoort = 2;
    // Start is called before the first frame update
    void Start()
    {
        maakobjecten();
    }
    void maakobjecten()
        {
        for (int i = 0; i < aantalFlessenPerSoort; i++)
        {
            randomRotation = Random.Range(-30f, 30f);
            Vector3 plaats1 = new Vector3(Random.Range(kleinsteXY, grootsteXY), hoogte, Random.Range(kleinsteXY, grootsteXY));
            GameObject afval1 = Instantiate(prefab1, plaats1, Quaternion.Euler(randomRotation, 0f, 0f));

            randomRotation = Random.Range(-30f, 30f);
            Vector3 plaats2 = new Vector3(Random.Range(kleinsteXY, grootsteXY), hoogte, Random.Range(kleinsteXY, grootsteXY));
            GameObject afval2 = Instantiate(prefab2, plaats2, Quaternion.Euler(randomRotation, 0f, 0f));

            randomRotation = Random.Range(-30f, 30f);
            Vector3 plaats3 = new Vector3(Random.Range(kleinsteXY, grootsteXY), hoogte, Random.Range(  kleinsteXY, grootsteXY));
            GameObject afval3 = Instantiate(prefab3, plaats3, Quaternion.Euler(randomRotation, 0f, 0f));
        }
        }
}
