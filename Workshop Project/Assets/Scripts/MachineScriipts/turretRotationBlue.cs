using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretRotationBlue : MonoBehaviour
{
    public GameObject machine;
    public Transform Target;
    public MachineShootBlue MachineShootBlue;

    Vector2 Direction;
    [SerializeField, Range(0, 100)] float RotationSpeed = 2;


    private void Start()
    {

    }

    void Update()
    {
        if (Target != null)
        {
            Vector3 targetDirection = Target.position - transform.position;
            float targetAngle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;

            Quaternion desiredRotation = Quaternion.Euler(0, 0, targetAngle);
            machine.transform.rotation = Quaternion.RotateTowards(machine.transform.rotation, desiredRotation, RotationSpeed * Time.deltaTime);
        }
    }
}
