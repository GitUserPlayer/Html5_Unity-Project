using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private float distz ,dy,dx;
    private Vector3 AA;
    [Range(0,15)]public float speed;
    void Start()
    {
        distz = -10;
        dx = -0.5f;
        dy = 4.3f;
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
       
        gameObject.transform.position =(new Vector3(dx, dy, distz));
        mouseDist();
    }
    void mouseDist() 
    {
        distz += Input.GetAxis("Mouse ScrollWheel")*speed;
        dx += Input.GetAxis("Mouse X")*Time.deltaTime*speed;
        dy += Input.GetAxis("Mouse Y")*Time.deltaTime*speed;

    }
}
