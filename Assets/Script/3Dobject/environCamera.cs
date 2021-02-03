using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class environCamera : MonoBehaviour
{
    public Transform target;
    [Range(0,15)]public float speed;
    
    public float test;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos);

        Quaternion current = transform.localRotation;
        transform.localRotation = Quaternion.Slerp(rotation, current, Time.deltaTime*test);

        transform.Translate(Time.deltaTime*speed,0,0);
    }
}
