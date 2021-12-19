using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var direction = Vector3.zero - other.transform.position;
        other.attachedRigidbody.AddForce(direction.normalized * 2, ForceMode.Impulse);
    }
}
