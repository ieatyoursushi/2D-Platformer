using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDelete : MonoBehaviour
{
    public GameObject Obstacle;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground" || col.gameObject.tag == "LightGround" )
        {
            Destroy(Obstacle, 0.18f);
            Debug.Log("Destroyed Obstacle");
        }
        if(col.gameObject.tag == "player")
        {
            Destroy(Obstacle);
        }
 
    }
}
