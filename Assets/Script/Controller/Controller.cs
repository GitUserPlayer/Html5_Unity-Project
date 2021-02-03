using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    private GameObject Ob_D;
    private GameObject post;

    public GameObject[] shop;
    public GameObject[] mainObject;
    
    bool isPaused;
    void Start()
    {
        //UIPanel.gameObject.SetActive(false); //make sure our pause menu is disabled when scene starts
        isPaused = false;
        for (int i =0;i<shop.Length ;i++) 
        {
            shop[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.R)) 
        {
            Ob_D.GetComponent<startRoate>().enabled = true;
            Ob_D.GetComponent<ObjectController>().MouseT = false;
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            Ob_D.GetComponent<startRoate>().enabled = false;
            Ob_D.GetComponent<ObjectController>().MouseT = true;
        }
        if (Input.GetKeyDown(KeyCode.P)) 
        {
            post.SetActive( true);
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            post.SetActive(false);
        }*/
       if (Input.GetKeyDown(KeyCode.Alpha0)) 
        {
            ScenesLoad(0);
        }
       /* if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        { Pause(); }
        else if ((Input.GetKeyDown(KeyCode.Escape) && isPaused))
        { UnPause(); }*/


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
        Debug.Log("SHOP");
       //shop[0].SetActive(true);
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
       
        //shop[0].SetActive(true);
        for (int i = 0; i < mainObject.Length; i++)
        {
            mainObject[i].SetActive(true);
        }

    }



    public void Pause()
    {
        isPaused = true;
       // UIPanel.gameObject.SetActive(true); //turn on the pause menu
        Time.timeScale = 0f; //pause the game
    }

    public void UnPause()
    {
        isPaused = false;
       // UIPanel.gameObject.SetActive(false); //turn off pause menu
        Time.timeScale = 1f; //resume game
    }
    public void RotationB() 
    {
        Ob_D.GetComponent<startRoate>().enabled = true;
        Ob_D.GetComponent<ObjectController>().MouseT = false;
    }
    public void MoveB()
    {
        Ob_D.GetComponent<startRoate>().enabled = false;
        Ob_D.GetComponent<ObjectController>().MouseT = true;
    }
    
}
