using UnityEngine;

public class CameraScript2D : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x, 0, -10) + offset;
    }
}
