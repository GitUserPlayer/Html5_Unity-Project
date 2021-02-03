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
   
    //enum
    public statusPlayer statusR;
  


    public GameObject target;
    public Color32 [] chairColor;

    public GameObject[] Inst;

    public GameObject[] ObjecttUI;



    private int colorI , obInt;

   

    public Controller Mcontroller;

    //UI
    public GameObject[] Rpro;
    public GameObject[] Tpro;

   



    void Start()
    {
        statusR = statusPlayer.general;
        colorI = -1;
        obInt = -1;
        for (int i = 0;i<ObjecttUI.Length ;i++)
        { ObjecttUI[i].SetActive(false); }
       

    }

   [System.Obsolete]
    void Update()
    {
        RayObject();
        if (Input.GetMouseButtonDown(1)) 
        {
            statusR = statusPlayer.general;
        }

        if (Input.GetKeyDown(KeyCode.R)) 
        {
            statusR = statusPlayer.color;

            for (int i = 0; i < Tpro.Length; i++)
            {
                Tpro[i].SetActive(false);
            }
            colorI += 1;
            obInt = -1;
            if (colorI >= chairColor.Length)
            {
                colorI = 0;            
            }
            if (Rpro[2].active == true) 
            {
                Rpro[2].SetActive(false);
            }

            Rpro[colorI].SetActive(true);

            if (colorI > 0) 
            {
                Rpro[colorI - 1].SetActive(false);
            }                                                                      
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            statusR = statusPlayer.objectT;
            for(int i = 0;i<Rpro.Length; i++) 
            {
                Rpro[i].SetActive(false);
            }

            colorI = -1;
            obInt += 1;
            if (obInt >= Inst.Length)
            {
                obInt = 0;
            }
            if (Tpro[2].active == true)
            {
                Tpro[2].SetActive(false);
            }

            Tpro[obInt].SetActive(true);

            if (obInt > 0) 
            {
                Tpro[obInt - 1].SetActive(false);
            }          
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
                    InstObj(obInt);
                }
                if (statusR == statusPlayer.color)
                {
                    changeColor(chairColor[colorI]);
                }
            }
            if (target.tag == "commodity")
            {
                int id =  target.GetComponent<ID_Object>().ID;
                ObjecttUI[id].SetActive(true);
            }
            
           
        }
    }
    public void ObjectActive(GameObject UiOb)
    {
        UiOb.SetActive(false);
    }
    public void BuyTime() 
    {
        Mcontroller.shop_Time();
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
    }
    public void ObInt(int num)
    {
        obInt = num;
    }
    void InstObj(int num) 
    {
        Instantiate(Inst[num],target.transform);
    }
   
}
