using System.Collections.Generic;
using UnityEngine;

public class TagManager : MonoBehaviour
{
    [SerializeField]
    private List<string> tagsList = new List<string>();

    // Method to check if the object has a specific tag
    public bool HasTag(string tagToCheck)
    {
        return tagsList.Contains(tagToCheck);
    }
}
