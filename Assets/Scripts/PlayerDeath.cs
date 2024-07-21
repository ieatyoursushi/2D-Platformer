using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class PlayerDeath : MonoBehaviour {
    bool gameEnded = false;
    public GameObject DeathAudio;
    public static AudioSource DeathAud;
    public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Debug.Log("lost");
            Invoke("Restart", 1f);
        }

    }
    void Restart()
    {
        DeathAud.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Start()
    {
        DeathAud = DeathAudio.GetComponent<AudioSource>();
    }
}
