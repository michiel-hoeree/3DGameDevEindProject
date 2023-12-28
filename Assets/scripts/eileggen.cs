using System.Collections;
using UnityEngine;

public class eileggen : MonoBehaviour
{
    public GameObject eiPrefab;
    public Transform eiSpawnPoint;
    public float legEiInterval = 5f;

    private bool canLayEgg = true;

    private void Start()
    {
        StartCoroutine(LegEierenRoutine());
    }

    IEnumerator LegEierenRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(legEiInterval);

            if (canLayEgg && VoedselSpeler.instance.GetVoedselInVoederbak() > 0)
            {
                LegEi();
            }
        }
    }

    void LegEi()
    {
        Instantiate(eiPrefab, eiSpawnPoint.position, Quaternion.identity);
        VoedselSpeler.instance.VerminderVoedselInVoederbak();
    }

    public void SetCanLayEgg(bool value)
    {
        canLayEgg = value;
    }
}
