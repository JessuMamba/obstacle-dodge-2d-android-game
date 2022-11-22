using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Unlock : MonoBehaviour {
    

    public GameObject lock1;
    public GameObject lock2;
    // Use this for initialization
    void Start () 
    {
        Scene scname = SceneManager.GetActiveScene ();
        if (scname.name == "difficulties") 
        {
            if (PlayerPrefs.GetInt ("E3") == 1) 
            {
                lock1.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("A3") == 1) 
            {
                lock2.SetActive (false);
            }
        }
        else if (scname.name == "Easy") 
        {
            if (PlayerPrefs.GetInt ("E1") == 1) 
            {
                lock1.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("E2") == 1) 
            {
                lock2.SetActive (false);
            }
        }
        else if (scname.name == "Average") 
        {
            if (PlayerPrefs.GetInt ("A1") == 1) 
            {
                lock1.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("A2") == 1) 
            {
                lock2.SetActive (false);
            }
        }
        else if (scname.name == "Difficult") 
        {
            if (PlayerPrefs.GetInt ("D1") == 1) 
            {
                lock1.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("D2") == 1) 
            {
                lock2.SetActive (false);
            }
        }

    }

    // Update is called once per frame
    void Update () 
    {
        


    }
}
