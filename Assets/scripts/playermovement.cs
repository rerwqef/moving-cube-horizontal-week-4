using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public static int number;// canvase showing coin collected
    Rigidbody rigidbody;
    [SerializeField] public float jumbforce;
[SerializeField] public float speed;                                                                        //for plyer movement.
    private bool canJump = true;
    public static float jumbscore;                                                                        //horizontal input for going left and right in x axis   
                                                                                                         //only if the player is in ground  plyer can jumb
    void Start()                           
    {
        rigidbody=GetComponent<Rigidbody>();
    }
                                                               
 
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");  //geting horizontal input in old input system
        if (horizontal < 0)                          //if horizontal input is less then zero plyer will go left
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);

        }
        else if (horizontal > 0)    //if greater then 0 plyer will go right
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);

        }
        if (Input.GetKeyDown(KeyCode.Space)&&canJump)    //used for jumbing,when user press space and canjumb varible is true plyer will jumb
        {
            rigidbody.AddForce(Vector3.up * jumbforce, ForceMode.Impulse); //forcemode.imPULES SUDDEN aayi jumb aavan
            jumbscore++;
            canJump = false;//jumb cheyyumbol thannea flase aavum,obectum aayi collide aavunnavare  false aayi nikkum
        }
        if (rigidbody.position.y < -1f)    //thazheakk poyal veendum game manager script activated aavum.engame activate aavum,if whant can also use transrsform.position.y/
        {
             FindObjectOfType<GameManager>().EndGame();
        }
       
    }
          private void OnCollisionEnter(Collision collision)     //predefined method
          {
        if (collision.gameObject.CompareTag("Ground"))    //if player collides with grounded taged gameobject  canjum varible will bacome true
                                                          //.plyer collides only grounded taged object when plyer is in ground
                                                          //plyer nlimited jumb can be resolved using it
        {                                              
            canJump = true;//collide aavumbol true aavum
        
        }
   
        
    }
    

}
       
