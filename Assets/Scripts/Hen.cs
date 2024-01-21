using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hen : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    private Transform _playerTransform;
    [SerializeField] private float _speed = 11f;
    [SerializeField] private float _timeToReashSpeed = 8f;

   


    void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMovement>().transform;

    }

    public void FixedUpdate()
    {
        if (_playerTransform)
        {
            Vector3 toPlayer = _playerTransform.position - transform.position;
            Quaternion toPlayerRotation = Quaternion.LookRotation(toPlayer, Vector3.up);
            transform.rotation = Quaternion.Lerp(transform.rotation, toPlayerRotation, Time.deltaTime * _timeToReashSpeed);
            _rigidbody.velocity = transform.forward * _speed;
        }
    }

   
   
    


   
   





}
