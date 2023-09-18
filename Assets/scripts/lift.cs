using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class lift : MonoBehaviour
{
   
    
    // Start is called before the first frame update
    private void Start()
    { 
        
       
    }

    private void Update()
    {
           void OnCollisionEnter(Collision collision)
        {
            

            if (collision.collider)
            {
            Debug.Log("1-working");
                if (Vector3.up.magnitude < transform.position.y)
                {
                 transform.Translate(Vector3.up * Time.deltaTime * 2f);
                Debug.Log("1-working");
                }
                else
                {
                    transform.Translate(Vector3.down * Time.deltaTime * 2f);
                }
                

            
        }
    }
 
    }
    // Update is called once per frame
  
}
