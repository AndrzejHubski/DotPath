using UnityEngine;

public class PathFollower2D : MonoBehaviour
{
    public PathCreator2D pathCreator;
    public int positionPoint = 250;

    private void FixedUpdate()
    {
        Vector3 pathInfo = pathCreator.path[positionPoint];
        transform.position = new Vector2(pathInfo.x, pathInfo.y);
        transform.eulerAngles = new Vector3(0, 0, pathInfo.z);
    }
}
