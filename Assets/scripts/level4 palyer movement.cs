using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

public class level4palyermovement : MonoBehaviour
{
    public float speed;   
    void Start()
    {
      
       
    }

 
    void Update()
    { 
        float m = Input.GetAxis("Horizontal");
         if (m < 0)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);


            
        }
 else   if (m > 0)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}
