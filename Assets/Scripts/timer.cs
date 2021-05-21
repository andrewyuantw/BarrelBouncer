using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class timer : MonoBehaviour
{
    private float timeRemaining = 30;
    public bool timerIsRunning = false;
    public GameObject time;
    public delegate void ARendGame();
    public static event ARendGame onEndGame;

    private void Start()
    {
        
        timerIsRunning = true;
    }
    
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
        else
        {
            Debug.Log("Time up");
            onEndGame();
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        

        TMP_Text currTime = time.GetComponent<TextMeshProUGUI>();
        currTime.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
