using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour {
    [SerializeField] private GameObject PauseMenuUI;
    public bool isPaused = false;
    [SerializeField] private bool pressed;
	// Use this for initialization
	void Start () {
        PauseMenuUI.SetActive(false);
        pressed = false;
        Time.timeScale = 1;
        isPaused = false;
	}
    private void Awake()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update () {

    }
    public void PressButton()
    {
        if (!isPaused)
        {
            pause();
            pressed = true;
             
        }
        Debug.Log("worked");

    }
    public void ResumeButton()
    {
        if (isPaused)
        {
            UnPause();
        } else
        {
            pause();
        }
    }
    public void pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void UnPause ()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void ResLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
