using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class PlayerController : MonoBehaviour {
    // vars
    public Camera Camera;
    [SerializeField]
    public static float moveSpeed;
    [SerializeField]
    public static float jumpSpeed;
    [SerializeField]Animator Animator;
    [SerializeField]float h; //horizontal axis
    [SerializeField]float v; //vertical axis
    bool facingRight;
    bool isGrounded;
    public GameObject LGround;
    public Sprite texture1;
    public GameObject player;
    public GameObject JumpAudio;
    public AudioSource JumpAud;
    bool activated = false;
    // use these for the shrink thing 
    public float number1 = 200;
    public float number2 = 3;
    private void Start()
    {
        moveSpeed = 5000;
        jumpSpeed = 6;
        JumpAud = JumpAudio.GetComponent<AudioSource>();
    }
    void Awake()
    {
        Animator = GetComponent<Animator>();
        moveSpeed = 5000;
        jumpSpeed = 6;
    }
     
    public void shrink()
    {
        float tSize = 0.01f;
        float x = 0;
        float y = tSize;
        float z = tSize;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = number1;
            jumpSpeed = number2;
            Debug.Log(moveSpeed + jumpSpeed);
            activated = true;
            gameObject.transform.localScale -= new Vector3(x, y, z);
            if (gameObject.transform.localScale.y <= 0.5f && gameObject.transform.localScale.z <= 0.5f)
            {
                gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
        } else
        {
            activated = false;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = 5000;
            jumpSpeed = 6;
            gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
    private void Update() { 
        move(h, v);
        shrink();
    }
 
    // Update is called once per frame
    void FixedUpdate () {
        LayerMask mask = LayerMask.GetMask("Level");

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        flip(h);
        // raycast collision detection
 
 
    }

    private void move(float h, float v)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(h * moveSpeed * Time.deltaTime, GetComponent<Rigidbody2D>().velocity.y);
        //jump if you press
        if (Input.GetKeyDown("space") && isGrounded)
        {
            Jump();
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(h * moveSpeed * Time.deltaTime, GetComponent<Rigidbody2D>().velocity.y);
        }
        // animator boolians
        if(h == 0)
        {
            Animator.SetBool("running", false);
        } else
        {
            Animator.SetBool("running", true);
        }
        if (!isGrounded)
        {
            Animator.SetBool("jumping", true);
        }
        else
        {
            Animator.SetBool("jumping", false);
        }
    
    }
    private void Jump()
    {

        GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpSpeed), ForceMode2D.Impulse);
        Animator.SetBool("jumping", true);
        JumpAud.Play();
    }

    private void flip(float h)
    {
        //IF the horizontal is negative and not facing right or if the horizontal is positive and facing right 
        if(h < 0 && !facingRight || h > 0  && facingRight) {
            facingRight = !facingRight;
            Vector3 tScale = transform.localScale;
            tScale.x = tScale.x * -1;
            transform.localScale = tScale;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if(other.gameObject.tag == "Ground")
        {
            isGrounded = true;
            Debug.Log("ground is true");
        }
        else
        {
            isGrounded = false;
        }
        // light ground platform
        if (other.gameObject.tag == "LightGround")
        {
            isGrounded = true;
        }
        if (other.gameObject.tag == "ObstacleM")
        {
           MinigameObstacle.lives -= 1;
           Debug.Log("Live Lost");
        }

    }
    void ChangeTexture()
    {
        GameObject.FindWithTag("LightGround").GetComponent<SpriteRenderer>().sprite = texture1;
        Debug.Log("texture changed");
    }
 
 
    private void OnCollisionExit2D(Collision2D other)
    {
        isGrounded = false;
    }
}
