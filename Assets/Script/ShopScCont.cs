using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopScCont : MonoBehaviour
{
    public GameObject[] shopUI;
    

    void Start()
    {
        for (int i =0;i<shopUI.Length ;i++ ) 
        {
            shopUI[i].SetActive(false);
        }
        shopUI[0].SetActive(true);     
    }

    
    public void SceneBack() 
    {
        SceneManager.LoadScene(0);
    }
    
    public void TObject_Active(GameObject trueOb) 
    {      
        trueOb.SetActive(true);
    }
    public void FObject_Active( GameObject falseOb)
    {
        falseOb.SetActive(false);
    }

}
