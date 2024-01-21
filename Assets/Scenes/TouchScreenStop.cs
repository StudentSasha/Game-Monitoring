using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScreenStop : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
#if UNITY_IOS || UNITY_ANDROID

       if(Input.touchCount > 0)
        {
            Touch myTouch = Input.GetTouch(0);
            if(myTouch.phase == TouchPhase.Began )
            {
                Ray ray = Camera.main.ScreenPointToRay(myTouch.position);
                RaycastHit hit;
                if(Physics.Raycast(ray, out hit))
                {
                    Debug.Log(hit.transform.name);
                }
            }
        }

#endif
    }
}
