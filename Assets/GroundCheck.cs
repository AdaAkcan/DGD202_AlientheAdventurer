using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
   public PlayerMovement player;

   public void OnTriggerEnter2D(Collider2D other) 
   {
    
       if (other.gameObject.CompareTag("Ground"))
        {
            player.isGrounded = true;
        }
   }
    public void OnTriggerExit2D(Collider2D other) 
   {
    
       if (other.gameObject.CompareTag("Ground"))
        {
            player.isGrounded = false;
        }
   }
}
