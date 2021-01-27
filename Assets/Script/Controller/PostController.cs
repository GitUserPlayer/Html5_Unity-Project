using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostController : MonoBehaviour
{
    public GameObject[] Post;
    public GameObject CameraPos;
    private GameObject postD;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        postD = GameObject.FindGameObjectWithTag("Post");


        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            PostInst(0);
            Debug.Log("0");
        }
        if (Input.GetKeyDown(KeyCode.O)) 
        {
            PostDestory();
        }
    }
    public void PostInst(int num) 
    {
        Instantiate(Post[num],CameraPos.transform);
    }
    public void PostDestory() 
    {
        Destroy(postD);
    }
}
