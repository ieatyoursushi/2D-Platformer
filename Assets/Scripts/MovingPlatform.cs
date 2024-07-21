using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {
    public GameObject Platform;
    public float speed;
    public Rigidbody2D RigidBody;
    public Transform positionA;
    public Transform positionB;
    public GameObject Player;

    public void Start()
    {
        RigidBody = Platform.GetComponent<Rigidbody2D>();
    }
    public void FixedUpdate()
    {
        RigidBody.AddForce(new Vector2(speed, 0), ForceMode2D.Force); 
        if(Platform.transform.position.x == positionA.position.x)
        {
            speed = 5;
        }
        if (Platform.transform.position.x == positionB.position.x)
        {
            speed = -5;
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {   
        if (col.gameObject.tag == "PositionA")
        {
            speed = 5;
            Debug.Log("Position A collided");
        } 
        if(col.gameObject.tag == "PositionB")
        {
            speed = -5;
            Debug.Log("Position B collided");
        }
        if(col.gameObject.tag == "player")
        {
            Physics2D.IgnoreCollision(Player.GetComponent<Collider2D>(), GetComponent<Collider2D>()); 
        }
    }
}
