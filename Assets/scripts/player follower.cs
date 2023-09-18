using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerfollower : MonoBehaviour
{
    public  Transform player;                            //for camara.camara wil alwayes follow the player in a correct distence .if the player moves in x,y,z camara will follow the player
    public Vector3 vector3;  //for getting camara position
                                        //camra actual position will added to players position in each frame
    void Update()
    {
      transform.position = player.position+vector3;//becuse if you not addedvector3 varable camar will follow the player but camara wiil stay the same positiobnn of player,it will be like first person view,using vector 3 we are adding  a specific axis value with it

    }
}
