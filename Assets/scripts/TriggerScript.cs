using System;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public event Action Ready;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == 9)
            Ready.Invoke();
    }
}
