using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float walkSpeed;
    private bool facingRight = true;
    public Animator runningMan;

    private void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        if (move < 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(move * walkSpeed, GetComponent<Rigidbody2D>().velocity.y);
            runningMan.SetBool("isWalking", true);
        }

        if (move > 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(move * walkSpeed, GetComponent<Rigidbody2D>().velocity.y);
            runningMan.SetBool("isWalking", true);
        }

        else if (move == 0)
        {
            runningMan.SetBool("isWalking", false);
        }


        if (facingRight == false && move > 0)
        {
            Flip();
        }
        else if (facingRight == true && move < 0)
        {
            Flip();
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
