using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PassengerCount : MonoBehaviour
{
    public int PassengerNo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PassengerNo < 0) 
        {
            PassengerNo = 0;
        }
        if (PassengerNo > 1)
        {
            PassengerNo = 1;
        }
    }
    void OnTriggerEnter (Collider other) 
    {
        if (other.gameObject.CompareTag("Passenger")) 
        {
            PassengerNo += 1;
            Destroy(other.gameObject);
        }
    }
}
