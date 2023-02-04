using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float Move;
    public Sprite spriteA;
    public Sprite spriteB;
    public float jump;
    public int transformation;
    public bool isJumping;
    public int treshold;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transformation = 0;
        speed = 5;
        treshold = 20;
    }


    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);
        while( speed >= treshold ){
            speed = speed - speed * 0.125f;
        }
        if(Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            Debug.Log("jump");
        }
        if(Input.GetKeyDown(KeyCode.L)){
            if(GetComponent<SpriteRenderer>().sprite != spriteA){
                transformation = transformation + 1;
                speed = 0.9f*speed;
            }
            GetComponent<SpriteRenderer>().sprite = spriteA;

        }
        if(Input.GetKeyDown(KeyCode.K)){
            if(GetComponent<SpriteRenderer>().sprite != spriteB){
                transformation = transformation + 1;
                speed = 1.9f*speed;

               }
            GetComponent<SpriteRenderer>().sprite = spriteB;

        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Ground")) {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
    }
}
