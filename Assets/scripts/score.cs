using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
  public Transform player;
    public  TextMeshProUGUI scoretext;


    // Update is called once per frame
    void Update()
    {
        scoretext.text = playermovement.number.ToString();//to convert  to string in score thhat shows in canvas
       
    }
}
