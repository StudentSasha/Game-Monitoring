using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private HingeJoint HingeJoint;
    [SerializeField] private GameObject PlayerMovement;
    
    [SerializeField] private Gama Gama;
    [SerializeField] private AudioSource _soundDoor;
    //[SerializeField] private AudioSource _soundFinal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody)
        {
            if (other.attachedRigidbody.GetComponent<PlayerMovement>())
            {
                JointSpring jointSpring = HingeJoint.spring;
                jointSpring.targetPosition = 90f;
                HingeJoint.spring = jointSpring;
                Invoke("StopScene", 3);
                PlayerMovement.SetActive(false);
                _soundDoor.Play();
                //_soundFinal.Play();
               
            }
        }
    }

    public void StopScene()
    {
       Gama.GamaFinish();
    }
}
