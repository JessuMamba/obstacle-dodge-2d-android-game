using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {
    public static bool GameIsPaused;
    public GameObject pausedMenuUI;
    public GameObject pausedMenubtn;

    // Use this for initialization
    void Start () {
        pausedMenuUI.SetActive(false);
        pausedMenubtn.SetActive(true);
        PlayerPrefs.SetInt ("Paused",0);

        GameIsPaused = false;
    }
    
    // Update is called once per frame
    void Update () {
        
    }
    public void Pause1()

    {     
        if (GameIsPaused == false)
        {
            Time.timeScale = 0f;
            pausedMenubtn.SetActive (false);
            pausedMenuUI.SetActive (true);
            PlayerPrefs.SetInt ("Paused",1);
            GameIsPaused = true;
        

        }

    }

    public void Resume()
    {
        if (GameIsPaused == true)
        {
            Scene Scenename = SceneManager.GetActiveScene ();
            if (Scenename.name == "easy1" || Scenename.name == "Average1" ||Scenename.name == "Difficult1" || Scenename.name =="Tutorial" ) 
            {
                Time.timeScale = 1.5f;
            } 
            else if(Scenename.name == "easy2" || Scenename.name == "Average2" ||Scenename.name == "Difficult2")
            {
                Time.timeScale = 2f;
            }
            else if(Scenename.name == "easy3" || Scenename.name == "Average3" ||Scenename.name == "Difficult3")
            {
                Time.timeScale = 3f;
            }
            PlayerPrefs.SetInt ("Paused",0);
            pausedMenubtn.SetActive (true);
            pausedMenuUI.SetActive (false);
            GameIsPaused = false;

        }
    }
    public void quitEasy()
    {
        SceneManager.LoadScene ("Easy");
    }
    public void quitAverage()
    {
        SceneManager.LoadScene ("Average");
    }
    public void quitDifficult()
    {
        SceneManager.LoadScene ("Difficult");
    }

}
