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
    private statusPlayer statusR;
  

    public GameObject target;
    public Color32 [] chairColor;

    public GameObject[] Inst;

    public int id;

    private int colorI , obInt;
  
    //UI
    public GameObject[] Rpro;
    public GameObject[] Tpro;


    public UI_Controller i_Cont;

 
    void Start()
    {
        statusR = statusPlayer.general;
        colorI = -1;
        obInt = -1;
    }

   [System.Obsolete]
    void Update()
    {
        RayObject(); 

       /* if (Input.GetMouseButtonDown(1)) 
        {
            statusR = statusPlayer.general;
            for (int i = 0;i<Rpro.Length ;i++) 
            {
                Rpro[i].SetActive(false);
            }
            for (int j = 0; j < Tpro.Length; j++)
            {
                Tpro[j].SetActive(false);
            }
        }*/

        /*if (Input.GetKeyDown(KeyCode.R)) 
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
        }  */    
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
                ObjectInteraction();
            }
            if (target.tag == "commodity")
            {
                id =  target.GetComponent<ID_Object>().ID;
                i_Cont.ObjectUi[id].SetActive(true);
            }           
           
        }
    }
   
   
    public void colorInt(int num) 
    {
        colorI = num;
    }
    public void ObInt(int num)
    {
        obInt = num;
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
   
    void InstObj(int num) 
    {
        Instantiate(Inst[num],target.transform);
    }

    void ObjectInteraction() 
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


}
