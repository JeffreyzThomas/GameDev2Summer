using UnityEngine;

public class Obstiacle : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
   {
        PlayerController player = collision.gameObject.GetComponent <PlayerController>();
        if (player!=null)   //this makes it to where only the player may get hit
       //This will end the game and destroy the player
        {
            Destroy(collision.gameObject);
        }
       
   }
  
    
   







}
