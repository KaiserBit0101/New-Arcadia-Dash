using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockBlock : MonoBehaviour
{

    public static int isVisible;
    public static bool saveExtra;
    public int internalVis;

    void Start()
    {
        isVisible = PlayerPrefs.GetInt("GotTheBlockUnlock");
    }

    void Update()
    {
        internalVis = isVisible;
        if (saveExtra == true)
        {
            saveExtra = false;
            isVisible = 1;
            PlayerPrefs.SetInt("GotTheBlockUnlock", 1);
        }
    }

}
