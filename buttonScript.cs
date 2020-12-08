using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour
{
    public Button food;
    public Button mood;
    public Button energy;

    // Start is called before the first frame update
    void Start()
    {
        food.onClick.AddListener(addHunger);
        mood.onClick.AddListener(addMood);
        energy.onClick.AddListener(addEnergy);
    }

    public void addHunger()
    {
        pet value = FindObjectOfType<pet>();
        value.hunger += 5;
        if (value.hunger >= 100)
        {
            value.hunger = 100;
        }
        else if (value.hunger < 100 && value.hunger > 0)
        {
            value.energy -= 10;
        }

    }
    public void addMood()
    {
        pet value = FindObjectOfType<pet>();
        value.mood += 10;
        if (value.mood >= 100)
        {
            value.mood = 100;
        }
        else if (value.mood < 100 && value.mood > 0)
        {
            value.hunger -= 15;
        }

    }
    public void addEnergy()
    {
        pet value = FindObjectOfType<pet>();
        value.energy += 30;
        if (value.energy >= 100)
        {
            value.energy = 100;
        }
        else if (value.energy < 100 && value.energy > 0)
        {
            value.mood -= 15;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
