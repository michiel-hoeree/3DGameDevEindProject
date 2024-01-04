using System.Collections.Generic;
using UnityEngine;

public class TagManager : MonoBehaviour
{
    [SerializeField]
    private List<string> tagsList = new List<string>();

    public bool HasTag(string tagToCheck)
    {
        return tagsList.Contains(tagToCheck);
    }
}
