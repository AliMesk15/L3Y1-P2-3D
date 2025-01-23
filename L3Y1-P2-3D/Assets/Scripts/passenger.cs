using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passenger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   void OnTriggerEnter(Collider other)
   {
    if (other.gameObject.CompareTag("Player")) 
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().currentPassengers++;
    }
}
}
