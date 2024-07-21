using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSize : MonoBehaviour {
    public Camera Camera;
    public float transitionSpeed = 0.001f;
    public float Csize = 8.57f;
    public GameObject player;
    void cameraSize()
    {
        if (player.transform.position.y >= 250)
        {
            transitionSpeed = 0.01f;
            Camera.main.GetComponent<Camera>().orthographicSize = transitionSpeed + Camera.orthographicSize;
            if (Camera.orthographicSize >= 12)
            {
                transitionSpeed = 0;
                Debug.Log("transition speed 0 ");
                Camera.orthographicSize = 12;
            }
            PlayerController.moveSpeed = 800;
            PlayerController.jumpSpeed = 7;
        }
        if (player.transform.position.y <= 3 && Camera.orthographicSize <= 12)
        {
            PlayerController.moveSpeed = 500;
            PlayerController.jumpSpeed = 6;
            Camera.main.GetComponent<Camera>().orthographicSize = Camera.orthographicSize + transitionSpeed;
            transitionSpeed = -0.01f;
            if (Camera.orthographicSize <= Csize)
            {
                transitionSpeed = 0;
                Camera.orthographicSize = Csize;
            }
        }

    }
    private void Start()
    {
        StartCoroutine(CameraSpeed());
    }
    IEnumerator CameraSpeed()
    {
        while (true)
        {
            cameraSize();
            yield return new WaitForSeconds(0.05f);
        }
    }

}

