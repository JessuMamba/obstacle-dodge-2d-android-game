using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class finnish : MonoBehaviour {
    public Collider2D finnishline;
    public Collider2D player;
    public Transform detector;
    public GameObject finnishpanel;
    //public GameObject unlockpanel;
    public GameObject pausebtn;
    public GameObject zerostar;
    public GameObject onestar;
    public GameObject twostar;
    public GameObject threestar;
    public AudioSource StopMusic;
    public AudioSource YouWinMusic;


    // Use this for initialization
    void Start () {
        finnishpanel.SetActive (false);
    

    }
    
    // Update is called once per frame
    void Update () {
        try{
            
            
        if (finnishline.IsTouching(player)) 
            {    

            Destroy (detector.gameObject );
            Destroy (finnishline.gameObject );
            
            pausebtn.SetActive (false);
                Scene scname = SceneManager.GetActiveScene();
                if(scname.name == "easy1")
                {
                    PlayerPrefs.SetInt("E1",1);
                    finnishpanel.SetActive (true);
                    collected();
                }
                else if (scname.name == "easy2")
                {
                    PlayerPrefs.SetInt("E2",1);
                    finnishpanel.SetActive (true);
                    collected();
                }
                else if (scname.name == "easy3")
                {
                    

                    PlayerPrefs.SetInt("E3",1);
                        finnishpanel.SetActive (true);
                        collected();

                }
                else if (scname.name == "Average1")
                {
                    PlayerPrefs.SetInt("A1",1);
                    finnishpanel.SetActive (true);
                    collected();
                }
                else if (scname.name == "Average2")
                {
                    PlayerPrefs.SetInt("A2",1);
                    finnishpanel.SetActive (true);
                    collected();
                }
                else if (scname.name == "Average3")
                {
                    PlayerPrefs.SetInt("A3",1);
                    finnishpanel.SetActive (true);
                    collected();
                }
                else if (scname.name == "Difficult1")
                {
                    PlayerPrefs.SetInt("D1",1);
                    finnishpanel.SetActive (true);
                    collected();
                }
                else if (scname.name == "Difficult2")
                {
                    PlayerPrefs.SetInt("D2",1);
                    finnishpanel.SetActive (true);
                    collected();
                }
                else if (scname.name == "Difficult3")
                {
                    PlayerPrefs.SetInt("D3",1);
                    finnishpanel.SetActive (true);
                    collected();
                    Debug.Log("d3");
                }
                YouWinMusic.Play();
                StopMusic.Stop();


        }

        }

        catch(MissingReferenceException e)
        {
            Debug.Log (e);

        }
    }




    public void collected()
    {
        Scene scname1 = SceneManager.GetActiveScene ();

        if (scname1.name == "easy1")
        {
            Debug.Log ("Easy1star");

            if (PlayerPrefs.GetInt ("stareasy1") == 0) {
                zerostar.SetActive (true);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (false);
                Debug.Log ("Easy1star =0");
            }
             
            else if (PlayerPrefs.GetInt ("stareasy1") == 1) {
                zerostar.SetActive (false);
                onestar.SetActive (true);
                twostar.SetActive (false);
                threestar.SetActive (false);
                Debug.Log ("Easy1star =1");
            } else if (PlayerPrefs.GetInt ("stareasy1") == 2) {
                zerostar.SetActive (false);
                onestar.SetActive (false);
                twostar.SetActive (true);
                threestar.SetActive (false);
                Debug.Log ("Easy1star =2");
            } else if (PlayerPrefs.GetInt ("stareasy1") == 3) {
                zerostar.SetActive (false);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (true);
                Debug.Log ("Easy1star =3");
            } else
            {
                Debug.Log ("X");
                Debug.Log (PlayerPrefs.GetInt("stareasy1"));
            }
        }

        else if (scname1.name == "easy2")
        {
            if (PlayerPrefs.GetInt ("stareasy2") == 0) {
                zerostar.SetActive (true);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (false);
                Debug.Log ("Easy1star =0");
            }

            else if(PlayerPrefs.GetInt ("stareasy2") == 1) 
            {
                zerostar.SetActive (false);
                onestar.SetActive (true);
                twostar.SetActive (false);
                threestar.SetActive (false);
            }
            else if(PlayerPrefs.GetInt ("stareasy2") == 2) 
            {        
                zerostar.SetActive (false);                
                onestar.SetActive (false);
                twostar.SetActive (true);
                threestar.SetActive (false);
            }
            else if(PlayerPrefs.GetInt ("stareasy2") == 3) 
            {
                zerostar.SetActive (false);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (true);
            }
        }
        else if (scname1.name == "easy3")
        {
            if (PlayerPrefs.GetInt ("stareasy3") == 0) {
                zerostar.SetActive (true);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (false);
                Debug.Log ("Easy1star =0");
            }

            else if(PlayerPrefs.GetInt ("stareasy3") == 1) 
            {
                zerostar.SetActive (false);
                onestar.SetActive (true);
                twostar.SetActive (false);
                threestar.SetActive (false);
            }
            else if(PlayerPrefs.GetInt ("stareasy3") == 2) 
            {
                zerostar.SetActive (false);
                onestar.SetActive (false);
                twostar.SetActive (true);
                threestar.SetActive (false);
            }

            else if(PlayerPrefs.GetInt ("stareasy3") == 3) 
            {        
                zerostar.SetActive (false);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (true);
            }
        }
        ////////////////////////////////////////////////////////////////////
        /// 
        if (scname1.name == "Average1")
        {
            Debug.Log ("AV1star");

            if (PlayerPrefs.GetInt ("staraverage1") == 0) {
                zerostar.SetActive (true);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (false);
                Debug.Log ("staraverage1 =0");
            }

            else if (PlayerPrefs.GetInt ("staraverage1") == 1) {
                zerostar.SetActive (false);
                onestar.SetActive (true);
                twostar.SetActive (false);
                threestar.SetActive (false);
                Debug.Log ("staraverage1 =1");
            } else if (PlayerPrefs.GetInt ("staraverage1") == 2) {
                zerostar.SetActive (false);
                onestar.SetActive (false);
                twostar.SetActive (true);
                threestar.SetActive (false);
                Debug.Log ("staraverage1 =2");
            } else if (PlayerPrefs.GetInt ("staraverage1") == 3) {
                zerostar.SetActive (false);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (true);
                Debug.Log ("staraverage1 =3");
            } else
            {
                Debug.Log ("X");
                Debug.Log (PlayerPrefs.GetInt("stareasy1"));
            }
        }

        else if (scname1.name == "Average2")
        {
            if (PlayerPrefs.GetInt ("staraverage2") == 0) {
                zerostar.SetActive (true);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (false);
                Debug.Log ("Easy1star =0");
            }

            else if(PlayerPrefs.GetInt ("staraverage2") == 1) 
            {
                zerostar.SetActive (false);
                onestar.SetActive (true);
                twostar.SetActive (false);
                threestar.SetActive (false);
            }
            else if(PlayerPrefs.GetInt ("staraverage2") == 2) 
            {        
                zerostar.SetActive (false);                
                onestar.SetActive (false);
                twostar.SetActive (true);
                threestar.SetActive (false);
            }
            else if(PlayerPrefs.GetInt ("staraverage2") == 3) 
            {
                zerostar.SetActive (false);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (true);
            }
        }
        else if (scname1.name == "Average3")
        {
            if (PlayerPrefs.GetInt ("staraverage3") == 0) {
                zerostar.SetActive (true);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (false);
                Debug.Log ("Easy1star =0");
            }

            else if(PlayerPrefs.GetInt ("staraverage3") == 1) 
            {
                zerostar.SetActive (false);
                onestar.SetActive (true);
                twostar.SetActive (false);
                threestar.SetActive (false);
            }
            else if(PlayerPrefs.GetInt ("staraverage3") == 2) 
            {
                zerostar.SetActive (false);
                onestar.SetActive (false);
                twostar.SetActive (true);
                threestar.SetActive (false);
            }

            else if(PlayerPrefs.GetInt ("staraverage3") == 3) 
            {        
                zerostar.SetActive (false);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (true);
            }
        }
        ////////////////////////////////////////////////////////////////////
        /// 
        if (scname1.name == "Difficult1")
        {
            Debug.Log ("Diff1star");

            if (PlayerPrefs.GetInt ("stardifficult1") == 0) 
            {
                zerostar.SetActive (true);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (false);
                Debug.Log ("staraverage1 =0");
            }

            else if (PlayerPrefs.GetInt ("stardifficult1") == 1) {
                zerostar.SetActive (false);
                onestar.SetActive (true);
                twostar.SetActive (false);
                threestar.SetActive (false);
                Debug.Log ("staraverage1 =1");
            } else if (PlayerPrefs.GetInt ("stardifficult1") == 2) {
                zerostar.SetActive (false);
                onestar.SetActive (false);
                twostar.SetActive (true);
                threestar.SetActive (false);
                Debug.Log ("staraverage1 =2");
            } else if (PlayerPrefs.GetInt ("stardifficult1") == 3) {
                zerostar.SetActive (false);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (true);
                Debug.Log ("staraverage1 =3");
            } else
            {
                Debug.Log ("X");
                Debug.Log (PlayerPrefs.GetInt("stardifficult1"));
            }
        }

        else if (scname1.name == "Difficult2")
        {
            if (PlayerPrefs.GetInt ("stardifficult2") == 0) {
                zerostar.SetActive (false);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (false);
                Debug.Log ("Easy1star =0");
            }

            else if(PlayerPrefs.GetInt ("stardifficult2") == 1) 
            {
                zerostar.SetActive (false);
                onestar.SetActive (true);
                twostar.SetActive (false);
                threestar.SetActive (false);
            }
            else if(PlayerPrefs.GetInt ("stardifficult2") == 2) 
            {        
                zerostar.SetActive (false);                
                onestar.SetActive (false);
                twostar.SetActive (true);
                threestar.SetActive (false);
            }
            else if(PlayerPrefs.GetInt ("stardifficult2") == 3) 
            {
                zerostar.SetActive (false);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (true);
            }
        }
        else if (scname1.name == "Difficult3")
        {
            if (PlayerPrefs.GetInt ("stardifficult3") == 0) {
                zerostar.SetActive (true);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (false);
                Debug.Log ("Easy1star =0");
            }

            else if(PlayerPrefs.GetInt ("stardifficult3") == 1) 
            {
                zerostar.SetActive (false);
                onestar.SetActive (true);
                twostar.SetActive (false);
                threestar.SetActive (false);
            }
            else if(PlayerPrefs.GetInt ("stardifficult3") == 2) 
            {
                zerostar.SetActive (false);
                onestar.SetActive (false);
                twostar.SetActive (true);
                threestar.SetActive (false);
            }

            else if(PlayerPrefs.GetInt ("stardifficult3") == 3) 
            {        
                zerostar.SetActive (false);
                onestar.SetActive (false);
                twostar.SetActive (false);
                threestar.SetActive (true);
            }
        }

    }


    public void ok()
    {
        finnishpanel.SetActive (true);

    }

}
