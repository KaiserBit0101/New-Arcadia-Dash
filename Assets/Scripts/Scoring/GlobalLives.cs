using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GlobalLives : MonoBehaviour
{
    public static int lifeCount;
    public int internalLife;
    public GameObject lifeDisplay;
    public static bool saveLives;
    public int firstStart;

    public void Start()
    {
        firstStart = PlayerPrefs.GetInt("StartingUp");
        if (firstStart == 0)
        {
            lifeCount = 10;
            firstStart = 1;
            PlayerPrefs.SetInt("StartingUp", firstStart);
            PlayerPrefs.SetInt("LifeCount", 10);
        }
        else
        {
            lifeCount = PlayerPrefs.GetInt("LifeCount");
        }

        lifeDisplay.GetComponent<Text>().text = "" + lifeCount;
    }
    void Update()
    {
        internalLife = lifeCount;
        if (saveLives == true)
        {
            saveLives = false;
            PlayerPrefs.SetInt("LifeCount", lifeCount);
            lifeDisplay.GetComponent<Text>().text = "" + lifeCount;
        }
    }
    public void menugo()
    {
        SceneManager.LoadScene(0);
    }
}
