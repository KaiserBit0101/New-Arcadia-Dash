using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TightOnRight : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        DesertBoundary.rightSide = 4;
    }

    void OnTriggerExit(Collider other)
    {
        DesertBoundary.rightSide = 6.7f;
    }
}
