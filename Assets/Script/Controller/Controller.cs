using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    private GameObject Ob_D;
   private GameObject post;




    [SerializeField]
    Transform UIPanel;
    bool isPaused;
    void Start()
    {
        //UIPanel.gameObject.SetActive(false); //make sure our pause menu is disabled when scene starts
        isPaused = false;
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
