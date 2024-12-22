using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalUnlocks : MonoBehaviour
{
    //tracks everything unlocked -- 0=locked   1=unlocked
    public static int doozyUnlock;
    


    void Start()
    {
        doozyUnlock = PlayerPrefs.GetInt("DoozyUnlock");
       
    }

    void Update()
    {
        
    }
}
