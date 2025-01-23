using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header ("Timer")]
    public float timer;
    public float timeLimit; 
    public TMP_Text timerText;
     
     [Header("Passengers")]
     public int requiredPassengers;
     public int currentPassengers;
     public TMP_Text passengerText;

    // Start is called before the first frame update
    void Start()
    {
        timer = timeLimit; 
    }

    // Update is called once per frame
    void Update()
    {
        GameTimer();
        Passengers();
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    void GameTimer()
    {
        timerText.text = timer.ToString("F2");
       
        if (timer <=0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else 
        {
             timer -= Time.deltaTime;
        }
    }
    void Passengers() 
    {
        passengerText.text = currentPassengers + " / " + requiredPassengers;
        if (currentPassengers == requiredPassengers)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
