using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopScCont : MonoBehaviour
{
    public GameObject main;
    public GameObject mo;
    public GameObject finish;

    void Start()
    {
        main.SetActive(true);
        mo.SetActive(false);
        finish.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneBack() 
    {
        SceneManager.LoadScene(0);
    }
    public void BuyOb() 
    {
        mo.SetActive(true);
        
        main.SetActive(false);

    }
    public void BuyOb2()
    {
        mo.SetActive(false);
        finish.SetActive(true);
        

    }
    public void NoB() 
    {
        mo.SetActive(false);
        main.SetActive(true);
    }
}
