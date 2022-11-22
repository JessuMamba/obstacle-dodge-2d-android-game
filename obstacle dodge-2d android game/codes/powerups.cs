using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour {
    public GameObject star;
    public Transform playerCheck;
    public float groundCheckRadius;
    public LayerMask whatIsPlayer;
    private bool onStar;
    public GameObject shield;
    public AudioSource Starsfx
    ;
    // Use this for initialization
    void Start () {
        shield.SetActive (false);

    }
    
    // Update is called once per frame
    void Update () {
        try{
        onStar = Physics2D.OverlapCircle (playerCheck.position, groundCheckRadius, whatIsPlayer);

        if (onStar) 
                
        {    PlayerPrefs.SetInt ("PowerUp",1);
            star.SetActive (false);
            shield.SetActive (true);
            Starsfx.Play();
    
            PowerUp ();
                StartCoroutine (PowerOff ());
        
            

        }
        
    
    }
    catch
    {
    }}
    public void PowerUp()
    {
        
    }
    IEnumerator PowerOff()
    {
        
    
        if (PlayerPrefs.GetInt ("Player") == 1) {
            yield return new WaitForSeconds (10f);
        } 
        else
        {
            yield return new WaitForSeconds (5f);
        }


        PlayerPrefs.SetInt ("PowerUp",0);
        shield.SetActive (false);



    }

}
