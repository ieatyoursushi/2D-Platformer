using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public CircleCollider2D CircleCollider2D;
    public GameObject Obstacle;

    public float minDelay;
    public float maxDelay;
    public GameObject ObjectSpawner;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // can pause the specific function instead of the whole game.
        StartCoroutine(SpawnObstacle());
    }
    // spawn obstacles function
    IEnumerator SpawnObstacle()
    {
        while (true)
        {
            GameObject i = Instantiate(Obstacle) as GameObject; // instantiate is a function that creates / clones an object which includes it's spawn position and it's rotation
            yield return new WaitForSeconds(Random.Range(minDelay, maxDelay)); // controls the speed of the while loop
            i.transform.position = new Vector2(ObjectSpawner.transform.position.x, ObjectSpawner.transform.position.y); // makes it so the obstacles spawn at the GameObjects position
            
        }
    }
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Obstacle")
        {
            CircleCollider2D.enabled = false;
        }
        else
        {
            CircleCollider2D.enabled = true;
        }
 
    }
    private void Update()
    {
        if(Obstacle.transform.position.y <= -10000)
        {
            Destroy(Obstacle);
            Debug.Log("Obstacle Destroyed");
        }
    }
    private void Inactive()
    {
        //Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
        //public Transform[] spawnPoints;
    }
}
 