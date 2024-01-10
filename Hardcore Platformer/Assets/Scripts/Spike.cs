using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public bool activeSpike;
    public bool moveSpike;
    public bool ActivateAnimation;
    public Vector2 moveDirection;
    public float speed;
    public float deadZone = -45;
    private Animator spikeAnimator;

    private void Start()
    {
        spikeAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (activeSpike && collision.gameObject.name.Equals("Player"))
        {
            if (ActivateAnimation == true)
            {
                spikeAnimator.SetTrigger("Activate");
            }
            
            moveSpike = true;
        }
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void FixedUpdate()
    {
        if (moveSpike)
        {
            Vector3 movement = new Vector3(moveDirection.x, moveDirection.y, 0) * speed;
            transform.position += movement * Time.deltaTime;

            if (transform.position.x < deadZone)
            {
                Destroy(gameObject);
            }
        }
    }
}
