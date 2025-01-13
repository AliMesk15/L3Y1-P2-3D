using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer;
    public float timeLimit; 
    public TMP_Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        timer = timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        GameTimer();
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
}
