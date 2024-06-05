using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;
    private Rigidbody2D rb;
    public bool isGrounded;

    private Animator animator;
    private SpriteRenderer _renderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
       
         animator.SetBool("walking", move != 0);
        
        if (move > 0) {
            _renderer.flipX = true;
        } else if (move < 0) {
            _renderer.flipX = false;

        } else if (rb.velocity.x != 0) {
            rb.velocity= new Vector2 (0,rb.velocity.y);
        }
        //rb.velocity = new Vector2(move * speed, rb.velocity.y);
         rb.AddForce(Time.deltaTime * ((speed * move)-(rb.velocity.x*50)) * Vector2.right, ForceMode2D.Force);
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            rb.AddForce(jumpForce * Vector2.up, ForceMode2D.Impulse);
        }

        if (isGrounded) {
            rb.gravityScale = 0;
        } else rb.gravityScale = 10;
    }

}
//This code is mostly generated with AI