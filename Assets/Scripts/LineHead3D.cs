using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineHead3D : MonoBehaviour
{
    public float rotationSpeed, speed;
    public GameObject dot;

    private void Start()
    {
        StartCoroutine(SpawnDot());
    }

    private void FixedUpdate()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
        transform.Rotate(new Vector3(-Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"), 0) * rotationSpeed * Time.deltaTime);
    }

    private IEnumerator SpawnDot()
    {
        Instantiate(dot, transform.position, transform.rotation);
        yield return new WaitForSecondsRealtime(0.5f);
        StartCoroutine(SpawnDot());
    }
}
