using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
   [Range(0,10)] public float speed;
    public float R_Time;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (R_Time<=360)
        {
            Rot();
        }
    }
    public void Rot() 
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime*10);
        Vector3 timeV = Vector3.up * speed * Time.deltaTime * 10;
        R_Time += timeV.y;
    }
    public void zeroT() 
    {
        if (R_Time>=360) 
        {
            R_Time = 0; 
        }
    }
}
