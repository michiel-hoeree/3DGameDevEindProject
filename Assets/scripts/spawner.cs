using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public List<Transform> targetObjects = new List<Transform>();
    public float spawnInterval = 5f; // Set the interval in seconds
    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, spawnInterval);
    }


    void SpawnObject()
    {

        GameObject newObject = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        
        Transform childTransform = newObject.transform.GetChild(1);
        SpiderAI scriptWithTarget = childTransform.GetComponent<SpiderAI>();
        if (scriptWithTarget != null)
        {
            int randomIndex = UnityEngine.Random.Range(0, targetObjects.Count);
            scriptWithTarget.SetTargetObject(targetObjects[randomIndex]);
        }
    }
}

