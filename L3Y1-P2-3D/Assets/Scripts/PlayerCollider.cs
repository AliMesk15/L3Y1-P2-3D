using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    public Vector3 lastPos;
    // Start is called before the first frame update
    void Start()
    {
        lastPos = transform.position; //lastPos is essentially our starting position
    }

   void OnTriggerEnter(Collider other)
   {
    if (other.gameObject.CompareTag("KillTrigger")) // checking for collision with KillTrigger tag
    {
        transform.position = lastPos;  // if character collides with KillTrigger tag, position is then reset to lastPos
    }
    if (other.gameObject.CompareTag("Checkpoint")) // checking for collision with Checkpoint tag
    {
        lastPos = transform.position; // if collision with Checkpoint tag is detected, player's current position becomes the new value for lastPos
    }
    
   }
}
