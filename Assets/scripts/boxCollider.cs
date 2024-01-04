    using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class CubeCollider : MonoBehaviour
{
    public Vector3 boxSize = new Vector3(1f, 1f, 1f);

    public string targetTag = "Bug";
    public GameObject beets;
    private void Update()
    {
        Collider[] colliders = Physics.OverlapBox(transform.position, boxSize / 2);
        foreach (var collider in colliders)
        {
            if (collider.CompareTag(targetTag))
            {
                //Debug.Log(collider + " bij de planten");
                collider.gameObject.transform.parent.gameObject.SetActive(false);
                ResetBeets();
                break;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, boxSize);
    }
    private void ResetBeets()
    {
        int i = 0;
        while (i< beets.transform.childCount)
        {
            if(i!=0)
            {
                Animator animator;
                Transform beet = beets.transform.GetChild(i);
                animator = beet.GetComponent<Animator>();
                animator.Play("beetGrowthAnimation", 0, 0f);
            }
            i++;
        }
    }
}
