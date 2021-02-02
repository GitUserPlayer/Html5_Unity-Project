using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostController : MonoBehaviour
{
    public GameObject[] Post;
    public GameObject CameraPos;
    public GameObject postD;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        postD = GameObject.FindGameObjectWithTag("Post");


        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            if (postD != null)
            {
                PostDestory();
                PostInst(0);
            }
            if (postD == null)
                PostInst(0);         
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (postD != null)
            {
                PostDestory();
                PostInst(1);
            }
            if (postD == null)
                PostInst(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            if (postD != null)
            {
                PostDestory();
                PostInst(2);
            }
            if (postD == null)
                PostInst(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (postD != null)
            {
                PostDestory();
                PostInst(3);
            }
            if (postD == null)
                PostInst(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5)) 
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
