using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    
     bool ended =false;                                                       
 // public static bool hasRestart

    public float restartdelayer = 1f;
    public GameObject complitelevelui;    // canvasimage that desabled
   // public GameObject player;
    public void levelcomplied()
    {
        complitelevelui.SetActive(true);  //comes true  
    //  player.SetActive(false);
    }
    public  void EndGame() 
    {

        if (ended == false) 
        {
            ended = true;
      //    hasRestarted = true; tried to changee value if restarts//

            Restart();
        }
    }
     void Restart()//same scene manager load aavum ,athayath restart aavum aa level
        {
          //  score.scoretext.text ="0" ;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);//for getting the cuurent active scene//
    }
    
}
