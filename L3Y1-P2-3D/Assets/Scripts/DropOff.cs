using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   void OnTriggerEnter (Collider other)
   {
    if  (other.gameObject.CompareTag("Player")) 
    {
        if (other.gameObject.GetComponent<PassengerCount>().PassengerNo == 1)
        {
            other.gameObject.GetComponent<PassengerCount>().PassengerNo --;
            GameObject.Find("GameManager").gameObject.GetComponent<GameManager>().timer += 10;
             GameObject.Find("GameManager").gameObject.GetComponent<GameManager>().currentPassengers++;

        }
    }
   }
}
