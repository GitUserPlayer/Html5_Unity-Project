using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    
    
    public GameObject[] shop;
    public GameObject[] mainObject;
    
    
    void Start()
    {
        
        
        for (int i =0;i<shop.Length ;i++) 
        {
            shop[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        
       if (Input.GetKeyDown(KeyCode.Alpha0)) 
        {
            ScenesLoad(0);
        }
       

    }
    public void ScenesLoad(int num) 
    {
        SceneManager.LoadScene(num);
       
    }
    public void shop_Time() 
    {
        for (int j = 0; j < shop.Length; j++)
        {
            shop[j].SetActive(true);
        }
       
        for (int i = 0;i< mainObject.Length; i++) 
        {
            mainObject[i].SetActive(false);
        }
        
    }
    public void shop_End()
    {
        for (int j = 0; j < shop.Length; j++)
        {
            shop[j].SetActive(false);
        }
       
    
        for (int i = 0; i < mainObject.Length; i++)
        {
            mainObject[i].SetActive(true);
        }

    }
    
    
    
}
