
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

    void Update()
    {
        postD = GameObject.FindGameObjectWithTag("Post");

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            PostTurn(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            PostTurn(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            PostTurn(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            PostTurn(4);
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
    private void PostTurn(int num) 
    {
        if (postD != null)
        {
            PostDestory();
            PostInst(num-1);
        }
        else 
        { PostInst(num-1); }      
    }
}
