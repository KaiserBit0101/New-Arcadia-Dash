using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashSequence : MonoBehaviour
{
    public GameObject changeText;

    void Start()
    {
        StartCoroutine(SplashToMenu());
    }



    IEnumerator SplashToMenu()
    {
        yield return new WaitForSeconds(4);
        changeText.SetActive(true);
        SceneManager.LoadScene(1);
    }
}
