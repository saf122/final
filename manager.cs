using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public GameObject moodText;
    public GameObject hungerText;
    public GameObject energyText;

    public GameObject pet;

    // Update is called once per frame
    void Update()
    {
        moodText.GetComponent<Text>().text = pet.GetComponent<pet>().mood.ToString();
        hungerText.GetComponent<Text>().text = pet.GetComponent<pet>().hunger.ToString();
        energyText.GetComponent<Text>().text = pet.GetComponent<pet>().energy.ToString();
    }
}
