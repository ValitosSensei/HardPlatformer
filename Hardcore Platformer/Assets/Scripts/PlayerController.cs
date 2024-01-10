using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForse;
    private float moveInput;
    private Animator animator;

    private Rigidbody2D rb;

    private bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;



    private int extraJumps;
    public int extraJumpValue;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        extraJumps = extraJumpValue;
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius,whatIsGround);
        
        
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2 (moveInput*speed,rb.velocity.y);
        if (moveInput != 0)
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }
        


        if (facingRight == false && moveInput >0)
        {
            Flip();
        }
        else if(facingRight == true && moveInput <0)
        {
            Flip();
        }
    }
    private void Update()
    {
        if(isGrounded==true)
        {
            extraJumps = extraJumpValue;
            animator.SetBool("Jump", false);
        }

        if(Input.GetKeyDown(KeyCode.Space)&&extraJumps>0)
        {
            rb.velocity = Vector2.up*jumpForse;
            extraJumps--;
            animator.SetBool("Jump", true);
        }else if (Input.GetKeyDown(KeyCode.Space) && extraJumps == 0&&isGrounded==true)
        {
            rb.velocity = Vector2.up * jumpForse;
        }
      
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }


   



}
