using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody Rigidbody;
    [SerializeField] private Animator animator;
    [SerializeField] private float speed;
    [SerializeField] private float speedRotation;

    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    public void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 inputDeriction = new Vector3(x, 0f, v);

        if(inputDeriction.magnitude > Mathf.Abs(0.05f))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(inputDeriction), Time.deltaTime * speedRotation);
            animator.SetFloat("speed", Vector3.ClampMagnitude(inputDeriction, 1).magnitude);
            Rigidbody.velocity = Vector3.ClampMagnitude(inputDeriction, 1) * speed;

            Rigidbody.angularVelocity = Vector3.zero;
        }
    }
}
