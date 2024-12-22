using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadAllValuesIn : MonoBehaviour
{
    public int totalDistanceValue;
    public int totalCoinValue;
    public int totalGemValue;
   
    public static bool hasPrevious = false; //states if we have pressed to start before
    public GameObject firstCam;
    public GameObject returnCam;
    
    public GameObject menuButtons;
   
    public static bool updateStats;
    

    void Start()
    {
        totalDistanceValue = PlayerPrefs.GetInt("TotalDistance");
        totalCoinValue = PlayerPrefs.GetInt("TotalCoins");
        totalGemValue = PlayerPrefs.GetInt("TotalGems");

       
        if (hasPrevious == true)
        {
            
            returnCam.SetActive(true);
            firstCam.SetActive(false);
         
            menuButtons.SetActive(true);
           
        }

    }
    void Update()
    {
        if (updateStats == true)
        {
            updateStats = false;
        totalDistanceValue = PlayerPrefs.GetInt("TotalDistance");
        totalCoinValue = PlayerPrefs.GetInt("TotalCoins");
        totalGemValue = PlayerPrefs.GetInt("TotalGems");
            
        }
    }

}
