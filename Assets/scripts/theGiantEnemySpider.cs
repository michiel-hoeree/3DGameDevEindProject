using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpiderAI : MonoBehaviour
{

    public Transform targetObject;
    public float rotationSpeed = 5f;
    public float moveSpeed = 3f;

    private bool isFacingTarget = false;

    void Update()
    {
        if (!isFacingTarget)
        {
            RotateTowardsTarget();

            if (IsFacingTarget())
            {
                isFacingTarget = true;
            }
        }
        else
        {
            MoveForward();
        }
    }
    void RotateTowardsTarget()
    {
        Vector3 directionToTarget = (targetObject.position - transform.position).normalized;

        Quaternion targetRotation = Quaternion.LookRotation(directionToTarget);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
    bool IsFacingTarget()
    {
        float angle = Vector3.Angle(transform.forward, (targetObject.position - transform.position).normalized);
        return Mathf.Abs(angle) < 1f;
    }
    void MoveForward()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
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