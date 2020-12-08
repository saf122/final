using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdownTimer : MonoBehaviour
{
    public string SceneNameWin;
    public string SceneNameLose;
    public Text timeText;

    public float timeRemaining = 10;
    public bool timerRunning = false;
    public int counterHunger1 = 0;
    public int counterHunger2 = 0;


    // Start is called before the first frame update
    void Start()
    {
        pet value = FindObjectOfType<pet>();
        timerRunning = true;
        InvokeRepeating("lowerHunger", 7f, 7f);
    }

    // Update is called once per frame
    void Update()
    {
        pet value = FindObjectOfType<pet>();
        lowerMood();
        lowerEnergy();

        if (timerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerRunning = false;
                if(value.hunger > 0 && value.mood > 0 && value.energy > 0)
                {
                    //Debug.Log("heyo");
                    SceneManager.LoadScene(SceneNameWin);
                }
            }
        }

        if(value.hunger <= 0 | value.mood <= 0 | value.energy <= 0)
        {
            SceneManager.LoadScene(SceneNameLose);
        }

    }

    void DisplayTime(float timeDisplay)
    {
        float minutes = Mathf.FloorToInt(timeDisplay / 60);
        float seconds = Mathf.FloorToInt(timeDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void lowerHunger()
    {
        pet value = FindObjectOfType<pet>();
        value.hunger -= 10;
        counterHunger1 += 1;
        counterHunger2 += 1;
    }

    void lowerMood()
    {
        pet value = FindObjectOfType<pet>();
        if (counterHunger1 == 3)
        {
            value.mood -= 20;
            counterHunger1 = 0;
        }
    }

    void lowerEnergy()
    {
        pet value = FindObjectOfType<pet>();
        if (counterHunger2 == 2)
        {
            value.energy -= 10;
            counterHunger2 = 0;
        }
    }

}