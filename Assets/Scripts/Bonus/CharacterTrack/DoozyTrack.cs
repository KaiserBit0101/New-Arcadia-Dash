using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoozyTrack : MonoBehaviour
{
    public static bool isOn;

    void Start()
    {
        isOn = true;
        RewardTrack.doozyCount += 1;
        RewardTrack.saveStats = true;
    }

}
