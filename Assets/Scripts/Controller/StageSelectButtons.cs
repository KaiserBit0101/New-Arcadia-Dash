using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelectButtons : MonoBehaviour
{
    //xbox
    public GameObject stageAButton;
    public GameObject stageLBButton;
    public GameObject stageRBButton;
    public GameObject charAButton;
    public GameObject charXButton;
    public GameObject charYButton;
    public GameObject charBButton;
    public GameObject charRBButton;
    public GameObject specialAButton;
    public GameObject specialLBButton;
    public GameObject specialRBButton;
    public GameObject charLTButton;
    public GameObject charRTButton;
    public GameObject extraAButton;
    public GameObject extraLBButton;
    public GameObject extraRBButton;

    //playstation
    public GameObject stageSquareButton;
    public GameObject charSquareButton;
    public GameObject charCircleButton;
    public GameObject charTriangleButton;
    public GameObject charCrossButton;
    public GameObject charR1Button;
    public GameObject specialSquareButton;
    public GameObject specialL1Button;
    public GameObject specialR1Button;
    public GameObject stageL1Button;
    public GameObject stageR1Button;
    public GameObject charL2Button;
    public GameObject charR2Button;
    public GameObject extraSquareButton;
    public GameObject extraL1Button;
    public GameObject extraR1Button;

    public bool isControl;

    void Update()
    {
        //isControl = TestJoys.joyOn;
    }
}
