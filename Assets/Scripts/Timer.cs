using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {
    public Text TimerText;
    [SerializeField]public static float CountDown = 0f;
    // Use this for initialization
    void Start()
    {
        
    }
	// Update is called once per frame
	void Update () {
        CountDown += Time.deltaTime;
        TimerText.text = CountDown.ToString("0") + " Seconds";
	}
}
