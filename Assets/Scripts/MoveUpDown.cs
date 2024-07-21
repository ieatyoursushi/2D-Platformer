using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class MoveUpDown : MonoBehaviour {
    public GameObject MovePlatform;
    public float ForceX, ForceY;
    public float localvalue;
    public Rigidbody2D rb;
    public bool isCollided;
    public GameObject movePlatformObject;
    
    // Use this for initialization
    void Start () {
        rb = MovePlatform.gameObject.GetComponent<Rigidbody2D>();
        rb.drag = 0;
        this.gameObject.GetComponent<AudioSource>().volume = 0.448f;
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            this.gameObject.GetComponent<AudioSource>().Play();
             
            if (isCollided)
            {
                 
                addforce();
                if (!isCollided)
                {
                     
                }
            }
        }
 
        if (collision.gameObject.tag == "player")
        {
            isCollided = true;
            Debug.Log("colliding");
    
        }  
    }
    void addforce()
    {
        rb.AddForce(new Vector2(ForceX * Time.deltaTime, ForceY * Time.deltaTime), ForceMode2D.Impulse);
        Debug.Log("adding force");
       
    }
    // Update is called once per frame
    void FixedUpdate () {
 
 

    }
    void dragValue()
    {
        if(ForceX == 0)
        {
             
        }
        else
        {
            if(ForceY == 0)
            {
                rb.drag = 0;
            }
        }
        
    }
}
