using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseTest : MonoBehaviour
{
    public bool lockM;

    


    void Start()
    {
        lockM = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) { lockM = false; }
        if (Input.GetMouseButtonDown(0)) { lockM = true; }
        mouseM();
    }
    void mouseM() 
    {
        if(lockM == true) 
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
    public void Bo() 
    {
        lockM = true;
    }
}
