using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class spike : MonoBehaviour {

    // Use this for initialization
    public GameObject pausebtn;
    public Collider2D spikes;
    public Collider2D player;
    public GameObject panelover;
    public AudioSource Sounds;
    public AudioSource Death;

    void Start () {
    }

    // Update is called once per frame
    void Update () {
        if (spikes.IsTouching(player) && PlayerPrefs.GetInt("PowerUp") == 0 && PlayerPrefs.GetInt("Player") != 4) 
        {
            Destroy (player.gameObject);
            Sounds.Stop ();
            Death.Play ();
            StartCoroutine (GO());
        }
        
    }
    IEnumerator GO()
    {
        yield return new WaitForSeconds (0.3f);



        panelover.SetActive (true);
        pausebtn.SetActive (false);


    }

}









    public void Charlock()
    {

        if (PlayerPrefs.GetInt ("E3") == 1)
        {
            P2lock.SetActive (false);
        }
        if (PlayerPrefs.GetInt ("A3") == 1) 
        {
            P3lock.SetActive (false);
        }
        if (PlayerPrefs.GetInt ("D3") == 1) {
            P4lock.SetActive (false);
        }
    }







    public void character1()
    {
        PlayerPrefs.SetInt ("Player", 1);

    }
    public void character2()
    {
        PlayerPrefs.SetInt ("Player", 2);
    
    }
    public void character3()
    {
        PlayerPrefs.SetInt ("Player", 3);
    
    }
    public void character4()
    {
        PlayerPrefs.SetInt ("Player", 4);

    }


}
