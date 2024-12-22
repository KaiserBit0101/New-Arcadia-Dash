using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCollisionDetect : MonoBehaviour
{
    public static bool hasCollided = false;
    public bool internalCheck;

    void Update()
    {
        internalCheck = hasCollided;
    }
}
