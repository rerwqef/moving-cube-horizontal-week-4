using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
//this script is disbled just used for seeing mathf function                                 //for knowing how can use math function
//using this object x,y,z values will go down and up,depending your fps//
//Magnitude = √(x^2 + y^2 + z^2)
//in 2d Magnitude = √(x^2 + y^2)           //magnitude size of object
public class sinaction : MonoBehaviour                                                       
{
    public float magnitude;//incresed size of object  will increse.
    public float sp;                                                                            // Mathf class function all are static 
    // Start is called before the first frame update                                                
public  float  sinamont()                                                              // function can recive a int value and return a                       
    {                                                                                                          
        return magnitude*Mathf.Sin(Time.time * sp);                                     //mathf .RoundToInt(2.6)=30r(2.1)=2 for a float value convert to int 
    }                                                                                   //matrhf.ceilToInt(2.1)=3 values round aakkum
                                                                                        //mathf.floorIn(2.6)=2lowest value;
    // Update is called once per frame
    void Update()
    {
        transform.localScale=new Vector3(sinamont(), sinamont(),sinamont());//
        UnityEngine. Debug.Log(transform.localScale);   //UnityEngine- errorr showes,for solving it//
    }  
}
