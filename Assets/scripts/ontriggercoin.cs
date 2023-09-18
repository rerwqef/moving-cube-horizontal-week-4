using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ontriggercoin : MonoBehaviour
{                                                                                                   //coin il player taged somethinfg trigger  avumbol gameobjectmeanse coin destroy aavum//
  //public static int numberdecreser;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")//player hites the gameobect gameobject willdestroyed//
        {
            Destroy(gameObject);
            playermovement.number++;   //coincollecting number increase aavum;
       //   numberdecreser++;
      /*   if(GameManager.hasRestarted)
            {                                    //tryed to change coin value//
playermovement.number = playermovement.number - numberdecreser;
            }*/
            
        }
        
    }
}
