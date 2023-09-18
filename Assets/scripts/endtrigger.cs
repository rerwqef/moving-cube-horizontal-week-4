using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endtrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public void OnTriggerEnter()  //trigger avumbol active aavum
    {

        gameManager.levelcomplied();   
        //  endtrigger script ulla object trigger avvumbol gamemanager lea leavelcomplited avum//
    }
}
