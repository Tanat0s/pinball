using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverScript : MonoBehaviour
{
    [SerializeField] private HingeJoint lever;
    [SerializeField]private float timeout;
    private float _currentTime = 0;


    // Update is called once per frame
    void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > timeout)
        {
            lever.useMotor = !lever.useMotor;
            _currentTime = 0;
        }
    }
}
