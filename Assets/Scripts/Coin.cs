using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Coin : MonoBehaviour {
    public GameObject Coins;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D col)
    {
       if(col.gameObject.tag == "player")
        {
            Debug.Log("coin: collided");
            Destroy(gameObject);
            this.gameObject.GetComponent<AudioSource>().Play();
            
        }
    }
}
