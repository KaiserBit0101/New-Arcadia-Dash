using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesertBoundary : MonoBehaviour
{

    public static float leftSide = -2;
    public static float rightSide = 6.7f;
    public float internalLeft;
    public float internalRight;


    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
