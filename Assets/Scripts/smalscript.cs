using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smalscript : MonoBehaviour {
    public GameObject Camera;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            Camera.GetComponent<Camera>().orthographicSize = 8;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
