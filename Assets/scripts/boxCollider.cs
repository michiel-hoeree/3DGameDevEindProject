using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollider : MonoBehaviour
{
    public Vector3 boxSize = new Vector3(1f, 1f, 1f);

    public string targetTag = "Bug";

    private void Update()
    {
        Collider[] colliders = Physics.OverlapBox(transform.position, boxSize / 2);
        foreach (var collider in colliders)
        {
            if (collider.CompareTag(targetTag))
            {
                Debug.Log(targetTag + " bij de planten");
                break;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, boxSize);
    }
}
