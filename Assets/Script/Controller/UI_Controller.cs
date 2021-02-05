using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Controller : MonoBehaviour
{
    public GameObject[] ObjectUi;

    void Start()
    {
        for (int i = 0;i < ObjectUi.Length ;i++) 
        {
            ObjectUi[i].SetActive(false);
        }
    }

    
    public void ObjectActive(GameObject UiOb)
    {
        UiOb.SetActive(false);
    }
}
