using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public GameObject Ob_D;
    public GameObject post;

   




    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
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
        }
       /*if (Input.GetKeyDown(KeyCode.Space)) 
        {
            ScenesLoad();
        }*/
    }
    public void ScenesLoad() 
    {
        SceneManager.LoadScene(0);
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
