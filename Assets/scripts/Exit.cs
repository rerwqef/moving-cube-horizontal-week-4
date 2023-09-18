using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    public void Quit()
    {
       
        Application.Quit();     // lastinterface ,when plyer press in button  exit function actives quit from the application
        
    }
}

