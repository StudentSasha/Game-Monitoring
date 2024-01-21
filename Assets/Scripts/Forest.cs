using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest : MonoBehaviour
{
    [SerializeField] private GameObject treePrefab;

    public void Start()
    {
        for (int i = 0; i < 2000; i++)
        {

            Vector3 position = new Vector3(Random.Range(-800f, 800f), 0.5f, Random.Range(-800f, 800f));
            GameObject tree = Instantiate(treePrefab, position, Quaternion.identity);
        }
    }
}
