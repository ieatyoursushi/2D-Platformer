using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour {
    public Text ScoreText;
	// Use this for initialization
	void Start () {
        ScoreText.text = " Amount of time survived: " + Timer.CountDown.ToString("0.00") + " Seconds";
 
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
