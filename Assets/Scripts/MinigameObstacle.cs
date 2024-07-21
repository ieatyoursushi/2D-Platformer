using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MinigameObstacle : MonoBehaviour {
    public GameObject ObstacleM;
    public static float lives = 3;
    public Text LiveText;
    private void OnCollisionEnter2D(Collision2D col)
    {

    }
    void Start () {
		
	}
	void Update () {
        LiveText.text = "Lives: " + lives.ToString();
        if (lives <= 0)
        {
            SceneManager.LoadScene("HowToPlay");
        }
        // color changer
        if (lives == 3)
        {
            LiveText.GetComponent<Text>().color = Color.green;
        }
        if (lives == 2)
        {
            LiveText.GetComponent<Text>().color = Color.yellow;
        }
        if (lives == 1)
        {
            LiveText.GetComponent<Text>().color = Color.red;
        }
    }
}
