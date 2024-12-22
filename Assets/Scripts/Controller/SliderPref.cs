using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderPref : MonoBehaviour
{
    public static float sliderSend;
    public Slider sliderObject;
    public float internalSlider;
    public float receiveValue;
    public bool startTracking;

    void Update()
    {
        if (startTracking == true)
        {
            internalSlider = sliderSend;
            sliderSend = sliderObject.value;
          
        }
    }

    void Start()
    {
        receiveValue = PlayerPrefs.GetFloat("ControlSetting");
        sliderObject.value = receiveValue;
        startTracking = true;
    }

}
