using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpiderAI : MonoBehaviour
{
    public Transform targetObject;
    public float moveSpeed = 5f;

    void Update()
    {
        if (targetObject != null)
        {
            MoveTowardsTarget();
        }
    }

    void MoveTowardsTarget()
    {
        Vector3 direction = targetObject.position - transform.position;
        direction.Normalize();

        transform.Translate(direction * moveSpeed * Time.deltaTime);

        Quaternion lookRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    public void SetTargetObject(Transform newTarget)
    {
        targetObject = newTarget;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the target object
        if (collision.transform == targetObject)
        {
            Debug.Log("Spider has reached the target!");
        }
    }
}