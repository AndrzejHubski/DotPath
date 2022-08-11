using UnityEngine;

public class PathFollower3D : MonoBehaviour
{
    public PathCreator3D pathCreator;
    public int positionPoint = 250;

    private void FixedUpdate()
    {
        transform.position = pathCreator.pathPosition[positionPoint];
        transform.rotation = pathCreator.pathRotation[positionPoint];
    }
}
