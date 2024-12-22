using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class Menucontrol : MonoBehaviour
{
   
    public GameObject menuButtons;  
   

    void Start()
    {
        // Coroutine'i başlat
        StartCoroutine(HandleClick());
    }

    IEnumerator HandleClick()
    {
       
       
        yield return new WaitForSeconds(1.5f);

        
        menuButtons.SetActive(true);
    }
    private void ResetAllGameData()
    {
        // Örnek olarak, PlayerPrefs sıfırlama
        PlayerPrefs.DeleteAll();

        
    }
    public void playbuttonclick()
    {
        ResetAllGameData();
        SceneManager.LoadScene(1);
    }
    public void ExitApplication()
    {
        
        Application.Quit();

       
    }
}
