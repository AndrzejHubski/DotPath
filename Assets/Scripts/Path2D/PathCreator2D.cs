using UnityEngine;

public class PathCreator2D : MonoBehaviour
{
    //x, y - position; z - rotation
    public Vector3[] path = new Vector3[500];

    private void Start()
    {
        for (int i = 0; i < path.Length - 1; i++)
        {
            path[i].x = i * 0.05f;
        }
        path[path.Length - 1] = path[path.Length - 2];
        transform.position = path[path.Length - 1];
    }

    private void FixedUpdate()
    {
        path[path.Length - 1] = new Vector3(transform.position.x, transform.position.y, transform.eulerAngles.z);
        for (int i = 0; i < path.Length - 1; i++)
        {
            path[i] = path[i + 1];
        }
    }
}
