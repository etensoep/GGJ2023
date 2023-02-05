using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   

    [SerializeField] private DialogUI dialogUI;

    public DialogUI DialogUI => dialogUI;
    public IInteractible Interactible {get; set; }

    public float speed;
    private float Move;
    public Sprite spriteA;
    public Sprite spriteB;
    public float jump;
    public int transformation;
    public bool isJumping;
    public bool inWater;
    public int treshold;
    public float startspeed;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transformation = 0;
        speed = 13;
        startspeed = speed;
        treshold = 20;
        jump = 350;
    }


    // Update is called once per frame
    void Update()
    {
        //if (dialogUI.isOpen) return;
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
                speed = 17;
                jump = 250;
                gameObject.layer=0;
            }
            GetComponent<SpriteRenderer>().sprite = spriteA;

        }
        if(Input.GetKeyDown(KeyCode.K)){
            if(GetComponent<SpriteRenderer>().sprite != spriteB){
                transformation = transformation + 1;
                speed = 9;
                jump = 450;
                gameObject.layer=3;
               }
            GetComponent<SpriteRenderer>().sprite = spriteB;
        }
        if(Input.GetKeyDown(KeyCode.E)){
            Interactible?.Interact(this);
        }

    }
    
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.CompareTag("Ground")) {
            isJumping = false;
        }

         if(other.gameObject.CompareTag("Water")) {
            inWater = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
        }
        if(other.gameObject.CompareTag("Water")) {
            inWater = false;
        }
    }

}
