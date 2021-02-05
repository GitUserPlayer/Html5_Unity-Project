using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScene : MonoBehaviour
{
    public int sceneID;
   
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") 
        {
            SceneManager.LoadScene(sceneID);
        }
    }
    
}
