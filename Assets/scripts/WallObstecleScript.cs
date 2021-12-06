using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallObstecleScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var direction = transform.position - other.transform.position;

        other.attachedRigidbody.AddForce(direction*-5, ForceMode.Impulse);
    }
}
