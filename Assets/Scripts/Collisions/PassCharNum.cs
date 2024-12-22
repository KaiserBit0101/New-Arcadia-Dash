using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassCharNum : MonoBehaviour
{
    public int charNum;

    void Start()
    {
        ManholeDrop.characterNumber = charNum;
    }
}
