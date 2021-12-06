using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var direction = transform.position - other.transform.position;

        other.attachedRigidbody.AddForce(new Vector3(0,0, 2), ForceMode.Impulse);
    }
}
