using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DelayedDeath : MonoBehaviour
{
    public Slider delaySlider;
    public TMP_Text delayText;
    float delay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateDelay()
    {
        string sliderMessage = "" + delaySlider.value;
        delayText.text = sliderMessage;
        delay = delaySlider.value;
    }
}
