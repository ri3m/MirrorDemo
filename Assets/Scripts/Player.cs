using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class Player : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }
    void HandleMovement(){
        //check if scipt is running on local player, bc we only want to use the players input for their movement, so that a player doesn't control someone else's movement 
        if(isLocalPlayer){
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement =new Vector3(moveHorizontal *0.1f, moveVertical *0.1f, 0); //multipling to slow movement
            transform.position=transform.position+movement;
        }
    }
    
}
