using System.Collections;
using System.Collections.Generic;
using UnityEngine;                           
                                                             //  for sesable box collider
                                                             //if 
public class gostmodecretor : MonoBehaviour

{
    public GameObject otherObject;   //getting player reffernce from unity

    public void OnTriggerEnter()              //if object triggerse players   boxcollider will turn off//
    {
         BoxCollider rb = otherObject.GetComponent<BoxCollider>();//box collider componat of player
        rb.enabled = false;
    }



}
