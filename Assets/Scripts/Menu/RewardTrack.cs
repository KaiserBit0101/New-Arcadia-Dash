using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardTrack : MonoBehaviour
{
    public static int timmyCount;
    public static int mouseyCount;
    public static int doozyCount;
    public static int claireCount;
    public static int bossCount;
    public int internalTimmy;
    public int internalMousey;
    public int internalDoozy;
    public int internalClaire;
    public int internalBoss;
    public static int whichChar;
    public static bool saveStats;

    void Start()
    {
        timmyCount = PlayerPrefs.GetInt("TimmyPlay");
        mouseyCount = PlayerPrefs.GetInt("MouseyPlay");
        doozyCount = PlayerPrefs.GetInt("DoozyPlay");
        claireCount = PlayerPrefs.GetInt("ClairePlay");
        bossCount = PlayerPrefs.GetInt("BossPlay");
        if (timmyCount > 7)
        {
            timmyCount = 0;
            PlayerPrefs.SetInt("TimmyPlay", 0);
        }
        if (mouseyCount > 7)
        {
            mouseyCount = 0;
            PlayerPrefs.SetInt("MouseyPlay", 0);
        }
        if (doozyCount > 7)
        {
            doozyCount = 0;
            PlayerPrefs.SetInt("DoozyPlay", 0);
        }
        if (claireCount > 7)
        {
            claireCount = 0;
            PlayerPrefs.SetInt("ClairePlay", 0);
        }
        if (bossCount > 7)
        {
            bossCount = 0;
            PlayerPrefs.SetInt("BossPlay", 0);
        }
    }

    void Update()
    {
        if (saveStats == true)
        {
            saveStats = false;
            PlayerPrefs.SetInt("TimmyPlay", timmyCount);
            PlayerPrefs.SetInt("MouseyPlay", mouseyCount);
            PlayerPrefs.SetInt("DoozyPlay",doozyCount);
            PlayerPrefs.SetInt("ClairePlay",claireCount);
            PlayerPrefs.SetInt("BossPlay",bossCount);
        }
        internalTimmy = timmyCount;
        internalMousey = mouseyCount;
        internalClaire = claireCount;
        internalDoozy = doozyCount;
        internalBoss = bossCount;
    }
}
