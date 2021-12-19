using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallObstecleScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 8)
        {
            var direction = collision.gameObject.transform.position - transform.position;
            collision.collider.attachedRigidbody.AddForce(direction.normalized * 15, ForceMode.Impulse);
        }
    }
}
