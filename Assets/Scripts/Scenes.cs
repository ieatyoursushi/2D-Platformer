using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenes : MonoBehaviour {
    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }
    public void Menus()
    {
        SceneManager.LoadScene("Menus");
        Timer.CountDown = 0;
        MinigameObstacle.lives = 3;
        
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void Level4()
    {
        SceneManager.LoadScene("Level 4");
    }
    public void Level5()
    {
        SceneManager.LoadScene("Level 5");
    }
    public void Level6()
    {
        SceneManager.LoadScene("Level 6");
    }
    public void Level7()
    {
        SceneManager.LoadScene("Level 7");
    }

    public void MiniGame()
    {
        SceneManager.LoadScene("MiniGame");
    }
    public void HowToPlay1() {
        SceneManager.LoadScene("HowToPlay 1");
    }
    public void PlayUI()
    {
        SceneManager.LoadScene("Menus 1");
    }
    public void Levels()
    {
        SceneManager.LoadScene("Menus 2");

    }
    public void MiniGame2()
    {
        SceneManager.LoadScene("MiniGame 1");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void Menus2()
    {
        SceneManager.LoadScene("Menus 2");
    }
    public void Menus3()
    {
        SceneManager.LoadScene("Menus 3");
    }
    public void Menus4()
    {
        SceneManager.LoadScene("Menus 4");
    }
    public void Menus5()
    {
        SceneManager.LoadScene("Menus 5");
    }
    public void Menus6()
    {
        SceneManager.LoadScene("Menus 6");
    }
    public void Menus7()
    {
        SceneManager.LoadScene("Menus 7");
    }
    public void Menus8()
    {
        SceneManager.LoadScene("Menus 8");
    }

}
