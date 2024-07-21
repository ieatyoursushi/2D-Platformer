using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class Respawn : MonoBehaviour {
    public Transform Player;
    public Text ScoreText;
    public GameObject Obstacle;
    public GameObject DeathAudio;
    public AudioSource DeathAud;
    public AudioSource DeathAud2;
    public GameObject DeathAudio2;
 
    void Update () {
        ScoreText.text = Player.position.x.ToString("0.00");
        if(Player.position.y <= -111)
        {
            Invoke("Revive", 0.5f);
            Debug.Log("respawned");
            MinigameObstacle.lives -= 1;
        }
 

    }
    private void FixedUpdate()
    {
        if (Player.position.y <= -100)
        {
            Invoke("sound", 0.01f);
        }
    }
    void sound()
    {
        if (!DeathAud.isPlaying)
        {
            DeathAud.Play();
        }
    }
    void sound2()
    {
        if (!DeathAud2.isPlaying)
        {
            DeathAud2.Play();
        }
    }
    private void Start()
    {
        DeathAud = DeathAudio.GetComponent<AudioSource>();
        DeathAud2 = DeathAudio2.GetComponent<AudioSource>();
    }
    void Revive()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Next Level");
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        //add audio in other scenes
        if(col.gameObject.tag == "Obstacle")
        {
            sound2();
            Invoke("Revive", 0.44f);
            Debug.Log("revived");
        }

        // finish lines
        if(col.gameObject.name == "Finish Line 1")
        {
            SceneManager.LoadScene("Level 2");
        }
        if (col.gameObject.name == "Finish Line 2")
        {
            SceneManager.LoadScene("Level 3");
        }
        if (col.gameObject.name == "Finish Line 3")
        {
            SceneManager.LoadScene("Level 4");
        }
        if (col.gameObject.name == "Finish Line 4")
        {
            SceneManager.LoadScene("Level 5");
        }
        if (col.gameObject.name == "Finish Line 5")
        {
            SceneManager.LoadScene("Level 6");
        }
        if (col.gameObject.name == "Finish Line 6")
        {
            SceneManager.LoadScene("Level 7");
        }
        if (col.gameObject.name == "Finish Line 7")
        {
            SceneManager.LoadScene("Menus");

        }
        
         
    }
 
    // creating a checkpint / finish line is similar to this but with a buildindex, it's easy!
    //notes
    // at the end of the game I want to create a small program with shenron and use an input box to communicate the wish to shenron using audio once all the 7 dragon balls are collected.
}
