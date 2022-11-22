using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider1 : MonoBehaviour {
    public Slider SliderMusic;
    public Slider SliderSfx;
    // Use this for initialization
    void Start () {
        SliderMusic.value = PlayerPrefs.GetFloat ("Music");
        SliderSfx.value = PlayerPrefs.GetFloat ("Sfx");
        
    }
    
    // Update is called once per frame
    void Update () {
        float SM;
        float SS;

        SM = SliderMusic.value;
        SS = SliderSfx.value;
        PlayerPrefs.SetFloat ("Music",SM);
        PlayerPrefs.SetFloat ("Sfx",SS);
        Debug.Log (SM +"SM");
        Debug.Log (SS + "SS");

        
    }
}
