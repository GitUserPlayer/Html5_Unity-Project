using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{
    public RayCont rayCont;

    public GameObject[] ObjectUi;

    public GameObject ObName;
    public GameObject Obshop;
    public GameObject UI3N;

    public Sprite[] shopMap;
    public Sprite[] NameMap;

    public int UI_ID;


    void Start()
    {
        for (int i = 0;i < ObjectUi.Length ;i++) 
        {
            ObjectUi[i].SetActive(false);
        }
    }
    private void Update()
    {
        UI_ID = rayCont.id;
        Obshop.GetComponent<Image>().sprite = shopMap[UI_ID];
        ObName.GetComponent<Image>().sprite = NameMap[UI_ID];
        UI3N.GetComponent<Image>().sprite = NameMap[UI_ID];
    }

    public void ObjectActive(GameObject UiOb)
    {
        UiOb.SetActive(false);
    }
    public void UiId(int num) 
    {
        UI_ID = num;
    }
}
