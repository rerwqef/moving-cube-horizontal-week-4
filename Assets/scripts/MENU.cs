using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
                                                                                                 
public class MENU : MonoBehaviour                                                          //for first scean-front interface
                                                                                           
{
                                                            //button press cheyyumbol onclick function  on aavum,statgame function enable aavum
  public void startgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   //sceanmanager will load next intex sceana
                                                                              
    }
   
}
