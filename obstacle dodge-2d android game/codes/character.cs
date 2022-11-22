using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterChange1 : MonoBehaviour {
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;
    public GameObject P2lock;
    public GameObject P3lock;
    public GameObject P4lock;
    public  Text Playertext;

    // Use this for initialization
    void Start () {
        
        string c1, c2, c3, c4;
        c1 = "Longer Shield time limit ";
        c2 = "Can't be killed by ice boulders";
        c3 = "Double jump";
        c4 = "Phase through spikes";
        if (PlayerPrefs.GetInt ("Player") == 1) {
            Player1.SetActive (true);
            Player2.SetActive (false);
            Player3.SetActive (false);
            Player4.SetActive (false);
            Playertext.text = c1;
        } else if (PlayerPrefs.GetInt ("Player") == 2) {
            Player1.SetActive (false);
            Player2.SetActive (true);
            Player3.SetActive (false);
            Player4.SetActive (false);
            Playertext.text = c2;
        } else if (PlayerPrefs.GetInt ("Player") == 3) {
            Player1.SetActive (false);
            Player2.SetActive (false);
            Player3.SetActive (true);
            Player4.SetActive (false);
            Playertext.text = c3;
        } else if (PlayerPrefs.GetInt ("Player") == 4) {
            Player1.SetActive (false);
            Player2.SetActive (false);
            Player3.SetActive (false);
            Player4.SetActive (true);
            Playertext.text = c4;
        } else
        
        {
            Player1.SetActive (true);
            Player2.SetActive (false);
            Player3.SetActive (false);
            Player4.SetActive (false);
            Playertext.text = c1;
        }
        Charlock ();
    }
    
    // Update is called once per frame
    void Update () {
        string c1, c2, c3, c4;
        c1 = "Longer Shield time limit ";
        c2 = "Can't be killed by ice boulders";
        c3 = "Double jump";
        c4 = "Phase through spikes";
        if (PlayerPrefs.GetInt ("Player") == 1) {
            Player1.SetActive (true);
            Player2.SetActive (false);
            Player3.SetActive (false);
            Player4.SetActive (false)    ;
            Playertext.text = c1;
        } else if (PlayerPrefs.GetInt ("Player") == 2) {
            Player1.SetActive (false);
            Player2.SetActive (true);
            Player3.SetActive (false);
            Player4.SetActive (false);
            Playertext.text = c2;

        } else if (PlayerPrefs.GetInt ("Player") == 3) {
            Player1.SetActive (false);
            Player2.SetActive (false);
            Player3.SetActive (true);
            Player4.SetActive (false);
            Playertext.text = c3;

        } else if (PlayerPrefs.GetInt ("Player") == 4) {
            Player1.SetActive (false);
            Player2.SetActive (false);
            Player3.SetActive (false);
            Player4.SetActive (true);
            Playertext.text = c4;
        } 
        else 
        
        {
            Player1.SetActive (true);
            Player2.SetActive (false);
            Player3.SetActive (false);
            Player4.SetActive (false);
            Playertext.text = c1;
        }
        Charlock ();
        
        
    }
