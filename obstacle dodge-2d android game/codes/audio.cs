using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour {
    public AudioSource Audio1;
    // Use this for initialization
    void Start () {
        Audio1 = GetComponent<AudioSource> ();
        Audio1.volume = PlayerPrefs.GetFloat ("Music");
    }
    
    // Update is called once per frame
    void Update () {
        if (Audio1.tag == "Music") {
            Audio1.volume = PlayerPrefs.GetFloat ("Music");
        } 
        else 
        {
            Audio1.volume = PlayerPrefs.GetFloat ("Sfx");    
        }
        
    }
}
