using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    [SerializeField] GameObject controller;
    [SerializeField] int time = 60;
    float currentTime;
    bool gameOver = false;
    TMPro.TMP_Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TMPro.TMP_Text>();
        currentTime = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            currentTime -= Time.deltaTime;
            updateTimer(currentTime);
        }
        if (currentTime < 0)
        {
            gameOver = true;
            controller.GetComponent<gameState>().gameOver = gameOver;
            timerText.text = $"";
        }
        
    }

    void updateTimer(float current)
    {
        current += 1;

        int seconds = Mathf.FloorToInt(current % time);
        if (seconds != 0)
        {
            timerText.text = $"{seconds}";
        }
        else if (seconds == 0)
        {
            timerText.text = $"{time}";
        }
    }
}
