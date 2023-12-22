using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveKip : MonoBehaviour
{



    public float speed = 5f;
    public float fenceDistance = 3f;
    public string fenceTag = "Fence";

    private Vector3 direction;

    void Start()
    {
        direction = RandomDirection();
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;

        if (Vector3.Distance(transform.position, FindClosestFence().transform.position) < fenceDistance)
        {
            direction = RandomDirection();
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    Vector3 RandomDirection()
    {
        Vector3 randomDirection = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
        return randomDirection;
    }

    GameObject FindClosestFence()
    {
        GameObject[] fences = GameObject.FindGameObjectsWithTag(fenceTag);
        GameObject closestFence = null;
        float closestDistance = Mathf.Infinity;

        foreach (GameObject fence in fences)
        {
            float distance = Vector3.Distance(transform.position, fence.transform.position);
            if (distance < closestDistance)
            {
                closestFence = fence;
                closestDistance = distance;
            }
        }

        return closestFence;
    }
}


