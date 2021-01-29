using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCont : MonoBehaviour
{
    public enum statusPlayer 
    {
        general,
        color,
        objectT
    }
    
    
    public GameObject target;
    public Color32 [] test;

    public GameObject[] Inst;
    public statusPlayer statusR;

    private int colorI , obInt;

    public Texture2D cursorTexture1;
    public Texture2D cursorTexture2;


    void Start()
    {
        statusR = statusPlayer.general;
        colorI = 0;
        obInt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        RayObject();
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            statusR = statusPlayer.color;
            Cursor.SetCursor(cursorTexture1, Vector2.zero, CursorMode.Auto);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            statusR = statusPlayer.objectT;
            Cursor.SetCursor(cursorTexture2, Vector2.zero, CursorMode.Auto);
        }

    }

    public void  RayObject() 
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0)&&Physics.Raycast(myRay,out hit)) 
        {
            target = hit.collider.gameObject;
            if (target.tag == "Object") 
            {
                if (statusR == statusPlayer.objectT)
                {
                    myDestroy();
                    InstObj();
                }
                if (statusR == statusPlayer.color)
                {
                    changeColor(test[colorI]);
                }
            }
        }
    }

    public void colorInt(int num) 
    {
        colorI = num;
    }
    public void changeColor(Color32 MyColor32)
    {
        
        if(target != null) 
        {
            target.transform.GetChild(0).gameObject.GetComponent<Renderer>().material.color = MyColor32;
        }
    }
    private void myDestroy()
    {
        for (int i = 0; i < target.transform.childCount; i++)
        {
            GameObject DestOb = target.transform.GetChild(i).gameObject;
            Destroy(DestOb);
        }
       
        Debug.Log("DDD");
    }
    public void ObInt(int num)
    {
        obInt = num;
    }
    void InstObj() 
    {
        Instantiate(Inst[obInt],target.transform);
    }


}
