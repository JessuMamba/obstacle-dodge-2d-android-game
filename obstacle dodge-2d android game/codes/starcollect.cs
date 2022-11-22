using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class starcollect2 : MonoBehaviour {
    public GameObject star;
    public Transform playerCheck;
    public float groundCheckRadius;
    public LayerMask whatIsPlayer;
    private bool onStar;
    public GameObject stars;
    public GameObject stars1;
    public GameObject stars2;
    public int stareasy1;
    public  Text starcounter;
    public AudioSource sfxstar;


    // Use this for initialization
    void Start () {
        

        stardontshow ();
    }
    
    // Update is called once per frame
    void Update ()
    {
        onStar = Physics2D.OverlapCircle (playerCheck.position, groundCheckRadius, whatIsPlayer);

        if (onStar) 
        {
            star.SetActive (false);

            getstar ();

            sfxstar.Play ();
        }


    }







    /// pagnakuha na
    public void stardontshow()
    {
        Scene scname = SceneManager.GetActiveScene ();
        if (scname.name == "easy1")
        {
            if (PlayerPrefs.GetInt ("star") == 1) {
                stars.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("star1") == 1) {
                stars1.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("star2") == 1) {
                stars2.SetActive (false);
            }
        }

        else if (scname.name == "easy2")
        {
            if (PlayerPrefs.GetInt ("starE2") == 1) {
                stars.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("starE21") == 1) {
                stars1.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("starE22") == 1) {
                stars2.SetActive (false);
            }
        }

        else if (scname.name == "easy3")
        {
            if (PlayerPrefs.GetInt ("starE3") == 1) {
                stars.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("starE31") == 1) {
                stars1.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("starE32") == 1) {
                stars2.SetActive (false);
            }
        }
        /////////////////////////////////////////////////////////
        else if (scname.name == "Average1")
        {
            if (PlayerPrefs.GetInt ("starA1") == 1) {
                stars.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("starA11") == 1) {
                stars1.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("starA12") == 1) {
                stars2.SetActive (false);
            }
        }

        else if (scname.name == "Average2")
        {
            if (PlayerPrefs.GetInt ("starA2") == 1) {
                stars.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("starA21") == 1) {
                stars1.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("starA22") == 1) {
                stars2.SetActive (false);
            }
        }

        else if (scname.name == "Average3")
        {
            if (PlayerPrefs.GetInt ("starA3") == 1) {
                stars.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("starA31") == 1) {
                stars1.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("starA32") == 1) {
                stars2.SetActive (false);
            }
        }

        /////////////////////////////////////////////////////////
        else if (scname.name == "Difficult1")
        {
            if (PlayerPrefs.GetInt ("starD1") == 1) {
                stars.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("starD11") == 1) {
                stars1.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("starD12") == 1) {
                stars2.SetActive (false);
            }
        }

        else if (scname.name == "Difficult2")
        {
            if (PlayerPrefs.GetInt ("starD2") == 1) {
                stars.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("starD21") == 1) {
                stars1.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("starD22") == 1) {
                stars2.SetActive (false);
            }
        }

        else if (scname.name == "Difficult3")
        {
            if (PlayerPrefs.GetInt ("starD3") == 1) {
                stars.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("starD31") == 1) {
                stars1.SetActive (false);
            }
            if (PlayerPrefs.GetInt ("starD32") == 1) {
                stars2.SetActive (false);
            }
        }


    }








    public void getstar()
    { 
        int stareasyplus1 = PlayerPrefs.GetInt ("stareasy1");
        int stareasyplus2 = PlayerPrefs.GetInt ("stareasy2");
        int stareasyplus3 = PlayerPrefs.GetInt ("stareasy3");
        int staraverageplus1 = PlayerPrefs.GetInt ("staraverage1");
        int staraverageplus2 = PlayerPrefs.GetInt ("staraverage2");
        int staraverageplus3 = PlayerPrefs.GetInt ("staraverage3");
        int stardifficultplus1 = PlayerPrefs.GetInt ("stardifficult1");
        int stardifficultplus2 = PlayerPrefs.GetInt ("stardifficult2");
        int stardifficultplus3 = PlayerPrefs.GetInt ("stardifficult3");
        int startotalplus = PlayerPrefs.GetInt ("startotal");
    //////////////////////////////////////////////////starE1
        if (star.name == "star") 
        {
            PlayerPrefs.SetInt ("star", 1);
            PlayerPrefs.SetInt ("stareasy1", stareasyplus1 + 1);
            PlayerPrefs.SetInt ("startotal",  startotalplus + 1);
        }
        if (star.name == "star1") 
        {
            PlayerPrefs.SetInt ("star1", 1);
            PlayerPrefs.SetInt ("stareasy1", stareasyplus1 + 1);
            PlayerPrefs.SetInt ("startotal", startotalplus + 1);
        }
        if (star.name == "star2") 
        {
            PlayerPrefs.SetInt ("star2", 1);
            PlayerPrefs.SetInt ("stareasy1", stareasyplus1 + 1 );
            PlayerPrefs.SetInt ("startotal",startotalplus + 1);
        }



        //////////////////////////////////////////////////////////////starE2

        if (star.name == "starE2") 
        {
            PlayerPrefs.SetInt ("starE2", 1);
            PlayerPrefs.SetInt ("stareasy2", stareasyplus2 + 1);
            PlayerPrefs.SetInt ("startotal", startotalplus +  1);
        }
        if (star.name == "starE21") 
        {
            PlayerPrefs.SetInt ("starE21", 1);
            PlayerPrefs.SetInt ("stareasy2", stareasyplus2 + 1);
            PlayerPrefs.SetInt ("startotal", startotalplus + 1);
        }
        if (star.name == "starE22") 
        {
            PlayerPrefs.SetInt ("starE22", 1);
            PlayerPrefs.SetInt ("stareasy2", stareasyplus2 + 1 );
            PlayerPrefs.SetInt ("startotal", startotalplus + 1);
        }


        ////////////////////////////////////////////////////////////////starE3
        if (star.name == "starE3") 
        {
            PlayerPrefs.SetInt ("starE3", 1);
            PlayerPrefs.SetInt ("stareasy3", stareasyplus3 +1);
            PlayerPrefs.SetInt ("startotal",  startotalplus + 1);
        }
        if (star.name == "starE31") 
        {
            PlayerPrefs.SetInt ("starE31", 1);
            PlayerPrefs.SetInt ("stareasy3", stareasyplus3 +1);
            PlayerPrefs.SetInt ("startotal", startotalplus + 1);
        }
        if (star.name == "starE32") 
        {
            PlayerPrefs.SetInt ("starE32", 1);
            PlayerPrefs.SetInt ("stareasy3", stareasyplus3 +1 );
            PlayerPrefs.SetInt ("startotal", startotalplus + 1);
        }


        /////////////////////////////////////////////////////////////////////
        /// 
        //////////////////////////////////////////////////starA1
        if (star.name == "starA1") 
        {
            PlayerPrefs.SetInt ("starA1", 1);
            PlayerPrefs.SetInt ("staraverage1", staraverageplus1 + 1);
            PlayerPrefs.SetInt ("startotal",  startotalplus + 1);
        }
        if (star.name == "starA11") 
        {
            PlayerPrefs.SetInt ("starA11", 1);
            PlayerPrefs.SetInt ("staraverage1", staraverageplus1 + 1);
            PlayerPrefs.SetInt ("startotal", startotalplus + 1);
        }
        if (star.name == "starA12") 
        {
            PlayerPrefs.SetInt ("starA12", 1);
            PlayerPrefs.SetInt ("staraverage1", staraverageplus1 + 1 );
            PlayerPrefs.SetInt ("startotal",startotalplus + 1);
        }



        //////////////////////////////////////////////////////////////starA2

        if (star.name == "starA2") 
        {
            PlayerPrefs.SetInt ("starA2", 1);
            PlayerPrefs.SetInt ("staraverage2", staraverageplus2 + 1);
            PlayerPrefs.SetInt ("startotal", startotalplus +  1);
        }
        if (star.name == "starA21") 
        {
            PlayerPrefs.SetInt ("starA21", 1);
            PlayerPrefs.SetInt ("staraverage2", staraverageplus2 + 1);
            PlayerPrefs.SetInt ("startotal", startotalplus + 1);
        }
        if (star.name == "starA22") 
        {
            PlayerPrefs.SetInt ("starA22", 1);
            PlayerPrefs.SetInt ("staraverage2", staraverageplus2 + 1 );
            PlayerPrefs.SetInt ("startotal", startotalplus + 1);
        }


        ////////////////////////////////////////////////////////////////starA3
        if (star.name == "starA3") 
        {
            PlayerPrefs.SetInt ("starA3", 1);
            PlayerPrefs.SetInt ("staraverage3", staraverageplus3 +1);
            PlayerPrefs.SetInt ("startotal3",  startotalplus + 1);
        }
        if (star.name == "starA31") 
        {
            PlayerPrefs.SetInt ("starA31", 1);
            PlayerPrefs.SetInt ("staraverage3", staraverageplus3 +1);
            PlayerPrefs.SetInt ("startotal", startotalplus + 1);
        }
        if (star.name == "starA32") 
        {
            PlayerPrefs.SetInt ("starA32", 1);
            PlayerPrefs.SetInt ("staraverage3", staraverageplus3 +1 );
            PlayerPrefs.SetInt ("startotal", startotalplus + 1);
        }
        /////////////////////////////////////////////////////////////////////
        /// 
        //////////////////////////////////////////////////starD1
        if (star.name == "starD1") 
        {
            PlayerPrefs.SetInt ("starD1", 1);
            PlayerPrefs.SetInt ("stardifficult1", stardifficultplus1 + 1);
            PlayerPrefs.SetInt ("startotal",  startotalplus + 1);
        }
        if (star.name == "starD11") 
        {
            PlayerPrefs.SetInt ("starD11", 1);
            PlayerPrefs.SetInt ("stardifficult1", stardifficultplus1 + 1);
            PlayerPrefs.SetInt ("startotal", startotalplus + 1);
        }
        if (star.name == "starD12") 
        {
            PlayerPrefs.SetInt ("starD12", 1);
            PlayerPrefs.SetInt ("stardifficult1", stardifficultplus1 + 1 );
            PlayerPrefs.SetInt ("startotal",startotalplus + 1);
        }



        //////////////////////////////////////////////////////////////starD2

        if (star.name == "starD2") 
        {
            PlayerPrefs.SetInt ("starD2", 1);
            PlayerPrefs.SetInt ("stardifficult2", stardifficultplus2 + 1);
            PlayerPrefs.SetInt ("startotal", startotalplus +  1);
        }
        if (star.name == "starD21") 
        {
            PlayerPrefs.SetInt ("starD21", 1);
            PlayerPrefs.SetInt ("stardifficult2", stardifficultplus2 + 1);
            PlayerPrefs.SetInt ("startotal", startotalplus + 1);
        }
        if (star.name == "starD22") 
        {
            PlayerPrefs.SetInt ("starD22", 1);
            PlayerPrefs.SetInt ("stardifficult2", stardifficultplus2 + 1 );
            PlayerPrefs.SetInt ("startotal", startotalplus + 1);
        }


        ////////////////////////////////////////////////////////////////starD3
        if (star.name == "starD3") 
        {
            PlayerPrefs.SetInt ("starD3", 1);
            PlayerPrefs.SetInt ("stardifficult3", stardifficultplus3 +1);
            PlayerPrefs.SetInt ("startotal3",  startotalplus + 1);
        }
        if (star.name == "starD31") 
        {
            PlayerPrefs.SetInt ("starD31", 1);
            PlayerPrefs.SetInt ("stardifficult3", stardifficultplus3 +1);
            PlayerPrefs.SetInt ("startotal", startotalplus + 1);
        }
        if (star.name == "starD32") 
        {
            PlayerPrefs.SetInt ("starD32", 1);
            PlayerPrefs.SetInt ("stardifficult3", stardifficultplus3 +1 );
            PlayerPrefs.SetInt ("startotal", startotalplus + 1);
        }


        /////////////////////////////////////////////////////////////////////
    




    
    }
}
