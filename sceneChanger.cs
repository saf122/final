using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    public string SceneName;
    [SerializeField]
    private int _counter;
    
    public void SelectionScene()
    {
        SceneManager.LoadScene("eggSelection");
    }

    public void endGame()
    {
        Application.Quit();
    }

    public void playYellowScene()
    {
        SceneManager.LoadScene("yellowPlay");
        counter = 1;
    }

    public void playBlueScene()
    {
        SceneManager.LoadScene("bluePlay");
        counter = 2;
    }

    public void playRedScene()
    {
        SceneManager.LoadScene("redPlay");
        counter = 3;
    }


    public int counter
    {
        get
        {
            return _counter;
        }
        set
        {
            _counter = value;
        }
    }
}
