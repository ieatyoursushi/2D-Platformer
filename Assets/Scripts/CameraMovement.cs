using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    //vars
    GameObject player;
    Vector3 offset;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("player");
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update () {
        transform.position = player.transform.position + offset;
	}
}
