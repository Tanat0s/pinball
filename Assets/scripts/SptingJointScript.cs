using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SptingJointScript : MonoBehaviour
{
    [SerializeField] private ConfigurableJoint springJoint;
    public TriggerScript startTrigger;
    public TriggerScript stopTrigger;
    bool isReady = true;
    JointDrive jointDrive = new JointDrive();
    JointDrive jointDriveZero = new JointDrive();
    private const float _timeout = 2;
    private float _currentTime = 0;

    private void Start()
    {
        startTrigger.Ready += StartTrigger_Ready;
        stopTrigger.Ready += StopTrigger_Ready;
        jointDrive.positionSpring = 5000;
        jointDrive.maximumForce = 2000;
        jointDrive.positionDamper = 1;
        jointDriveZero.positionSpring = 0;
        jointDriveZero.maximumForce = 2000;
        jointDriveZero.positionDamper = 1;
    }

    private void StartTrigger_Ready()
    {
        isReady = true;
    }

    private void StopTrigger_Ready()
    {
        isReady = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isReady)
        {
            _currentTime += Time.deltaTime;
            if(_currentTime > _timeout)
            {
                springJoint.transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime / 2);
                springJoint.xDrive = jointDriveZero;
            }
        }
        else
        {
            _currentTime = 0;
            springJoint.xDrive = jointDrive;
        }
    }

}
