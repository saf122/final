using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pet : MonoBehaviour
{
    [SerializeField]
    private int _hunger;
    [SerializeField]
    private int _mood;
    [SerializeField]
    private int _energy;

    void Start()
    {
        updateStats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateStats()
    {
        //HUNGER valu saves
        if(!PlayerPrefs.HasKey("hunger"))
        {
            hunger = 100;
            PlayerPrefs.SetInt("hunger", hunger);
        }
        else
        {
            hunger = PlayerPrefs.GetInt("hunger");
        }

        //MOOD values saves
        if (!PlayerPrefs.HasKey("mood"))
        {
            mood = 100;
            PlayerPrefs.SetInt("mood", mood);
        }
        else
        {
            mood = PlayerPrefs.GetInt("mood");
        }

        //ENERGY values saves
        if (!PlayerPrefs.HasKey("energy"))
        {
            energy = 100;
            PlayerPrefs.SetInt("energy", energy);
        }
        else
        {
            energy = PlayerPrefs.GetInt("energy");
        }
    }

    public int hunger
    {
        get
        { 
            return _hunger; 
        }
        set
        { 
            _hunger = value; 
        }
    }
    public int mood
    {
        get 
        { 
            return _mood; 
        }
        set 
        { 
            _mood = value; 
        }
    }
    public int energy
    {
        get
        {
            return _energy;
        }
        set
        {
            _energy = value;
        }
    }
}
