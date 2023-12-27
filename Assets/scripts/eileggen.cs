using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eileggen : MonoBehaviour
{
    public GameObject eiPrefab;
    public Transform eiSpawnPoint;
    public float legEiInterval = 5f;

    private void Start()
    {
        StartCoroutine(LegEierenRoutine());
    }

    IEnumerator LegEierenRoutine()
    {
        while (true)
        {
            LegEi();
            yield return new WaitForSeconds(legEiInterval);
        }
    }

    void LegEi()
    {
        Instantiate(eiPrefab, eiSpawnPoint.position, Quaternion.identity);
    }
}
