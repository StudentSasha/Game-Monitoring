using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatchPrefabCreate : MonoBehaviour
{
    [SerializeField] private Transform _prefab;
    [SerializeField] private Transform[] _spawn;

  

   

        
    
    public void Create()
    {
        
        for (int i = 0; i < _spawn.Length; i++)
        {
             Instantiate(_prefab, _spawn[i].position, Quaternion.identity);
        }
    }
    
   
}
