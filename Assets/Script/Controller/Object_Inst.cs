using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Inst : MonoBehaviour
{
    public GameObject[] obScene;
    
    public GameObject trans;
    private GameObject DestO;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestO = GameObject.FindGameObjectWithTag("Ob");
    }
    public void Inst_Ob(int numOb) 
    {
       

       
            trans.transform.position = Vector3.zero;
            trans.transform.rotation = Quaternion.identity;
            Instantiate(obScene[numOb], trans.transform);
        
        
    }
    public void ObDestroy()
    {
        
            Destroy(DestO);
        
    }
}
