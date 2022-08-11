using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathCreator3D : MonoBehaviour
{
    public Vector3[] pathPosition = new Vector3[500];
    public Quaternion[] pathRotation = new Quaternion[500];

    private void Start()
    {
        for (int i = 0; i < pathPosition.Length - 1; i++)
        {
            pathPosition[i].z = i * 0.05f;
        }
        pathPosition[pathPosition.Length - 1] = pathPosition[pathPosition.Length - 2];
        transform.position = pathPosition[pathPosition.Length - 1];
    }

    private void FixedUpdate()
    {
        pathPosition[pathPosition.Length - 1] = transform.position;
        for (int i = 0; i < pathPosition.Length - 1; i++)
        {
            pathPosition[i] = pathPosition[i + 1];
        }

        pathRotation[pathPosition.Length - 1] = transform.rotation;
        for (int i = 0; i < pathRotation.Length - 1; i++)
        {
            pathRotation[i] = pathRotation[i + 1];
        }
    }
}
