using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Waypoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit))
        {
            transform.position = hit.point;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.up);
        Gizmos.DrawSphere(transform.position + Vector3.up, .2f);
    }
}
