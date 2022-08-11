using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotDestroying : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Dot"))
        {
            Destroy(other.gameObject);
        }
    }
}
