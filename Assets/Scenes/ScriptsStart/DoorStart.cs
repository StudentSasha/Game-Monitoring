using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorStart : MonoBehaviour
{
    [SerializeField] private HingeJoint HingeJoint;
    [SerializeField] private GameObject PlayerMovement;


    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
        {
            if (other.attachedRigidbody.GetComponent<PlayerMovement>()){
                JointSpring jointSpring = HingeJoint.spring;
                jointSpring.targetPosition = 90f;
                HingeJoint.spring = jointSpring;

                PlayerMovement.SetActive(false);
            }
        }
    }
}
