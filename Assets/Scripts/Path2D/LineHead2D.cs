using System.Collections;
using UnityEngine;

public class LineHead2D : MonoBehaviour
{
    public float rotationSpeed, speed;
    public GameObject dot;

    private void Start()
    {
        StartCoroutine(SpawnDot());
    }

    private void FixedUpdate()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime * Input.GetAxis("Vertical"));
    }

    private IEnumerator SpawnDot()
    {
        Instantiate(dot, transform.position, transform.rotation);
        yield return new WaitForSecondsRealtime(0.5f);
        StartCoroutine(SpawnDot());
    }
}
