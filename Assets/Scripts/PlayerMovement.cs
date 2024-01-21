using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float _speed;
    [SerializeField] private float runingSpeed = 6f;
    [SerializeField] private float currentSpeed;
    [SerializeField] private float _speedRotation;
    [SerializeField] private Animator animator;
    [SerializeField] private float animationInterpolation = 1f;
    [SerializeField] private float horizontal;
    [SerializeField] private float vertical;
    [SerializeField] FixedJoystick joystick;
    [SerializeField] private float lerpMultiplayer = 2f;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

   


    public void FixedUpdate()
    {

       
        animationInterpolation = Mathf.Clamp(animationInterpolation, 1f, Time.deltaTime);
        animator.SetFloat("speed", horizontal * animationInterpolation);
        animator.SetFloat("speed", vertical * animationInterpolation);

        currentSpeed = Mathf.Lerp(currentSpeed, runingSpeed, Time.deltaTime);



        horizontal = Mathf.Lerp(horizontal, joystick.Horizontal, Time.deltaTime * lerpMultiplayer);
        vertical = Mathf.Lerp(vertical, joystick.Vertical, Time.deltaTime * lerpMultiplayer);
      
        Vector3 inputDeriction = new Vector3(horizontal, 0f, vertical);

        if (inputDeriction.magnitude > Mathf.Abs(0.05f))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(inputDeriction), Time.deltaTime * _speedRotation);
            animator.SetFloat("speed", Vector3.ClampMagnitude(inputDeriction, 1).magnitude);
            rb.velocity = Vector3.ClampMagnitude(inputDeriction, 1) * _speed;
            rb.angularVelocity = Vector3.zero;
        }

    }

}