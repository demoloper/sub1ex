using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class parentControl : MonoBehaviour
{
    public GameObject Sub;
    public Camera maincamera;
    public GameObject subposition;
    public GameObject Sub1;

    void Start()
    {
        runInEditMode = true;
       
    }

    
    void Update()
    {
        //uret();
        

    }
    public void uret() 
    {
        
        if (Sub1.transform.childCount>0)
        {
            for (int i = 0; i < 100; i++)
                      
            {
                Vector3 pos = subposition.transform.position + new Vector3(i * 0.9f, 0, 0);
                Instantiate(Sub, pos, Quaternion.identity);
            }
        }
 }
}
