using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFadeOff : MonoBehaviour
{
    public GameObject fadeIn;
    


    void Start()
    {
        StartCoroutine(FadeOff());
    }


    IEnumerator FadeOff()
    {
        yield return new WaitForSeconds(0.5f);
        fadeIn.SetActive(false);
    }
}
