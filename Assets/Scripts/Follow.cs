using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _lerpRate;
    

    void Update()
    {
        if( _target != null)
        {
            transform.position = Vector3.Lerp(transform.position, _target.position, Time.deltaTime * _lerpRate);
        }
        

    }
}
