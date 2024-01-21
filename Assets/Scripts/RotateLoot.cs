using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLoot : MonoBehaviour
{
    [SerializeField] private Vector3 _rotateSpeed;


    void Update()
    {
        transform.Rotate(_rotateSpeed * Time.deltaTime);
    }
}
