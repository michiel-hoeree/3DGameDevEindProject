using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollider : MonoBehaviour
{
    // Specify the size of the box
    public Vector3 boxSize = new Vector3(1f, 1f, 1f);

    // Specify the tag of the objects you want to detect
    public string targetTag = "YourTargetTag";

    private void Update()
    {
        // Use Physics.OverlapBox to get all colliders within the specified box area
        Collider[] colliders = Physics.OverlapBox(transform.position, boxSize / 2);

        // Check each collider for the specified tag and log if found
        foreach (var collider in colliders)
        {
            if (collider.CompareTag(targetTag))
            {
                Debug.Log("Object with tag '" + targetTag + "' detected in the cube!");
                break; // Break out of the loop after the first detection if desired
            }
        }
    }

    private void OnDrawGizmos()
    {
        // Visualize the box in the Scene view
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, boxSize);
    }
}
