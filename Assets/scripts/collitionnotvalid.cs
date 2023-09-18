using System.Collections;
using System.Collections.Generic;
using UnityEngine;
                                                                            
public class collitionnotvalid : MonoBehaviour                        //if the player hits somthing taged orhite,game will restarted
{                                                                    
 [SerializeField]  public GameObject player;
 
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)                      
    {

        if (collision.collider.tag == "outhite")
        {
            GetComponent<playermovement>().enabled = false;   //if the plyer hits the taged objectplayer movement componat become desable//
          //  FindObjectOfType<GameManager>().EndGame();
            GameManager gameManager = FindObjectOfType<GameManager>();//gamemanager componet refernce
            gameManager.EndGame();    //if collide aayal gamemanager ilea endgame function call avvum,then end gasme function lea reastart invoke aavum
          
    }  
        }
    
}
